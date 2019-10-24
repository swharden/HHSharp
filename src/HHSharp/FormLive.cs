using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHSharp
{
    public partial class FormLive : Form
    {
        public Simulator sim;
        public double[] voltage;

        public FormLive()
        {
            InitializeComponent();
            formsPlot1.plt.mouseTracker.lowQualityWhileInteracting = false;
        }

        private void FormLive_Load(object sender, EventArgs e)
        {
            sim = new Simulator(constantCurrent: (double)nudCurrentConstant.Value);
            voltage = sim.voltage.ToArray();
            formsPlot1.plt.Clear();
            formsPlot1.plt.PlotSignal(voltage, sim.sampleRateHz / 1000, color: Color.Blue, yOffset: -70);
            formsPlot1.plt.YLabel("Membrane Potential (mV)");
            formsPlot1.plt.XLabel("Simulation Time (ms)");
            formsPlot1.plt.Title("Hodgkin–Huxley model: Continuous Simulation");
            formsPlot1.plt.AxisAuto(0, 0);
            formsPlot1.plt.Axis(y1: -100, y2: 50);
            formsPlot1.Render();

            // set initial GUI values
            cbEpsc.Checked = true;
            nudEpscFreq.Value = 50;
            nudEpscAmp.Value = 5;
            nudCurrentConstant.Value = -10;
            cbEpsc_CheckedChanged(null, null);
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            Array.Copy(sim.voltage.ToArray(), 0, voltage, 0, voltage.Length);
            formsPlot1.plt.Clear(signalPlots: false);
            formsPlot1.plt.PlotVLine(sim.voltageIndex / sim.sampleRateHz * 1000, color: Color.Red, lineWidth: 3);
            formsPlot1.Render(skipIfCurrentlyRendering: true);

            string formattedMessage = (cbSimulationSlow.Checked) ? "{0:0.000} sec" : "{0:0.00} sec";
            lblTime.Text = string.Format(formattedMessage, sim.totalRunTimeSec);

            btnReset.Visible = double.IsNaN(sim.model.Vm);

        }

        private void cbSimulationRun_CheckedChanged(object sender, EventArgs e)
        {
            sim.timer.Enabled = cbSimulationRun.Checked;
        }

        private void nudEpscAmp_ValueChanged(object sender, EventArgs e)
        {
            sim.epscAmplitude = (double)nudEpscAmp.Value;
        }

        private void nudEpscFreq_ValueChanged(object sender, EventArgs e)
        {
            sim.epscFrequencyHz = (double)nudEpscFreq.Value;
        }

        private void cbEpsc_CheckedChanged(object sender, EventArgs e)
        {
            nudEpscAmp.Enabled = cbEpsc.Checked;
            nudEpscFreq.Enabled = cbEpsc.Checked;
            sim.epscAmplitude = (cbEpsc.Checked) ? (double)nudEpscAmp.Value : 0;
            sim.epscFrequencyHz = (cbEpsc.Checked) ? (double)nudEpscFreq.Value : 0;
        }

        private void cbSimulationSlow_CheckedChanged(object sender, EventArgs e)
        {
            sim.slowMotion = cbSimulationSlow.Checked;
        }

        private void nudCurrentConstant_ValueChanged(object sender, EventArgs e)
        {
            sim.constantCurrent = (double)nudCurrentConstant.Value;
        }

        private void btnDeliverPulse_Click(object sender, EventArgs e)
        {
            sim.squarePulseAmplitude = (double)nudSquarePulseAmp.Value;
            sim.squarePulseMsRemaining = (double)nudSquarePulseLength.Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormLive_Load(null, null);
        }
    }
}
