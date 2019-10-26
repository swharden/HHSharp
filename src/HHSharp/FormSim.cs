using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHSharp
{
    public partial class FormSim : Form
    {
        public FormSim()
        {
            InitializeComponent();
            formsPlot1.plt.mouseTracker.lowQualityWhileInteracting = false;
            formsPlot3.plt.mouseTracker.lowQualityWhileInteracting = false;
            formsPlot2.plt.mouseTracker.lowQualityWhileInteracting = false;
            RunSimulation();
        }

        private void FormSim_Load(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                using (var frm = new FormLive())
                    frm.ShowDialog();
            }
        }

        private double[] GenerateStimulusWaveform(int pointCount)
        {
            double[] stimulus = new double[pointCount];

            if (rbStimConstant.Checked)
            {
                for (int i = 0; i < pointCount; i++)
                    stimulus[i] = (double)nudStimCurrent.Value;
            }
            else if (rbStimSquare.Checked)
            {
                int indexStart = (int)(pointCount * .33);
                int indexEnd = (int)(pointCount * .66);
                for (int i = indexStart; i < indexEnd; i++)
                    stimulus[i] = (double)nudStimCurrent.Value;
            }
            else if (rbStimRamp.Checked)
            {
                for (int i = 0; i < pointCount; i++)
                    stimulus[i] = (double)nudStimCurrent.Value * i / pointCount;
            }
            else
            {
                throw new NotImplementedException();
            }

            return stimulus;
        }

        private void RunSimulation()
        {

            // For simple simulations, just use the simulator class.
            // Interact with the HHModel directly (like this) only if you want to do a lot of tweaking.

            Stopwatch stopwatch = Stopwatch.StartNew();

            double stepSizeMsec = .01;
            double sampleRate = 1.0 / stepSizeMsec;
            double simulationLengthMsec = (double)nudDurationMs.Value;
            int pointCount = (int)(simulationLengthMsec / stepSizeMsec);

            double[] voltage = new double[pointCount];
            double[] stateH = new double[pointCount];
            double[] stateM = new double[pointCount];
            double[] stateN = new double[pointCount];

            double[] INa = new double[pointCount];
            double[] IK = new double[pointCount];
            double[] IKleak = new double[pointCount];

            double[] stimulus = GenerateStimulusWaveform(pointCount);

            var hh = new HHModel
            {
                ENa = (double)nudENa.Value,
                EK = (double)nudEK.Value,
                EKleak = (double)nudEKLeak.Value,
                gNa = (double)nudGNa.Value,
                gK = (double)nudGK.Value,
                gKleak = (double)nudGKLeak.Value,
                Cm = (double)nudCm.Value
            };

            for (int i = 0; i < pointCount; i++)
            {
                hh.StepForward(stimulus[i], stepSizeMsec);
                voltage[i] = hh.Vm;
                stateH[i] = hh.h.activation;
                stateM[i] = hh.m.activation;
                stateN[i] = hh.n.activation;
                INa[i] = hh.INa;
                IK[i] = hh.IK;
                IKleak[i] = hh.IKleak;
            }

            double elapsedSec = (double)stopwatch.ElapsedTicks / Stopwatch.Frequency;
            string message = string.Format("Simulated {2:n0} time points\nin {0:0.00} ms ({1:0.00} Hz)",
                elapsedSec * 1000.0, 1 / elapsedSec, pointCount);
            rtbStatus.Text = message;

            formsPlot1.plt.Title("Membrane Potential (Vm)");
            formsPlot1.plt.YLabel("Potential (mV)");
            formsPlot1.plt.Clear();
            formsPlot1.plt.PlotSignal(voltage, sampleRate, yOffset: -70, color: Color.Blue);
            formsPlot1.plt.AxisAuto();
            formsPlot1.Render();

            formsPlot3.plt.Title("Stimulus");
            formsPlot3.plt.YLabel("Current (µA/cm²)");
            formsPlot3.plt.Clear();
            formsPlot3.plt.PlotSignal(stimulus, sampleRate, color: Color.Red);
            formsPlot3.plt.AxisAuto();
            formsPlot3.Render();

            formsPlot2.plt.Clear();
            if (rbDisplayActivity.Checked == true)
            {
                formsPlot2.plt.Title("Voltage-Dependent Gate Activation");
                formsPlot2.plt.YLabel("Activation (frac)");
                formsPlot2.plt.PlotSignal(stateH, sampleRate, label: "h");
                formsPlot2.plt.PlotSignal(stateM, sampleRate, label: "m");
                formsPlot2.plt.PlotSignal(stateN, sampleRate, label: "n");
            }
            else if (rbDisplayCurrent.Checked == true)
            {
                formsPlot2.plt.Title("Channel Current");
                formsPlot2.plt.YLabel("Current (µA/cm²)");
                formsPlot2.plt.PlotSignal(INa, sampleRate, label: "VGSC");
                formsPlot2.plt.PlotSignal(IK, sampleRate, label: "VGKC");
                formsPlot2.plt.PlotSignal(IKleak, sampleRate, label: "Kleak");
            }
            else
            {
                throw new NotImplementedException();
            }
            formsPlot2.plt.XLabel("Simulation Time (milliseconds)");
            formsPlot2.plt.Legend();
            formsPlot2.plt.AxisAuto();
            formsPlot2.Render();

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            lblUrl.Font = new Font(lblUrl.Font.Name, lblUrl.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            lblUrl.Font = new Font(lblUrl.Font.Name, lblUrl.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lblUrl_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/swharden/HHSharp");
        }

        private void nudStimCurrent_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void rbStimConstant_CheckedChanged(object sender, EventArgs e) { RunSimulation(); }
        private void rbStimSquare_CheckedChanged(object sender, EventArgs e) { RunSimulation(); }
        private void rbStimRamp_CheckedChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudCm_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudResolutionMs_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudDurationMs_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudGKLeak_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudGK_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudGNa_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudEKLeak_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudEK_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void nudENa_ValueChanged(object sender, EventArgs e) { RunSimulation(); }
        private void rbDisplayActivity_CheckedChanged(object sender, EventArgs e) { RunSimulation(); }
        private void rbDisplayCurrent_CheckedChanged(object sender, EventArgs e) { RunSimulation(); }

        private void formsPlot1_AxesChanged(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                formsPlot2.plt.MatchAxis(formsPlot1.plt, horizontal: true, vertical: false);
                formsPlot3.plt.MatchAxis(formsPlot1.plt, horizontal: true, vertical: false);
                formsPlot2.Render(true);
                formsPlot3.Render(true);
            }
        }

        private void formsPlot3_AxesChanged(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                formsPlot1.plt.MatchAxis(formsPlot3.plt, horizontal: true, vertical: false);
                formsPlot2.plt.MatchAxis(formsPlot3.plt, horizontal: true, vertical: false);
                formsPlot1.Render(true);
                formsPlot2.Render(true);
            }
        }

        private void formsPlot2_AxesChanged(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                formsPlot1.plt.MatchAxis(formsPlot2.plt, horizontal: true, vertical: false);
                formsPlot3.plt.MatchAxis(formsPlot2.plt, horizontal: true, vertical: false);
                formsPlot1.Render(true);
                formsPlot3.Render(true);
            }
        }

        private void btnLaunchLive_Click(object sender, EventArgs e)
        {
            using (var frm = new FormLive())
                frm.ShowDialog();
        }
    }
}
