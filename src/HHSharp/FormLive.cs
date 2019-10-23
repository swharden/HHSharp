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
        public readonly Simulator sim;
        public readonly double[] voltage;
        public double pulseTimeRemaining;

        public FormLive()
        {
            InitializeComponent();
            sim = new Simulator(initialCurrent: (double)nudCurrentConstant.Value);
            voltage = sim.voltage.ToArray();
            formsPlot1.plt.PlotSignal(voltage, sim.sampleRateHz / 1000, color: Color.Blue, yOffset: -70);
            formsPlot1.plt.YLabel("Membrane Potential (mV)");
            formsPlot1.plt.XLabel("Simulation Time (ms)");
            formsPlot1.plt.Title("Hodgkin–Huxley model: Continuous Simulation");
            formsPlot1.plt.AxisAuto(0, 0);
            formsPlot1.plt.Axis(y1: -100, y2: 50);
            formsPlot1.Render();
        }

        private void FormLive_Load(object sender, EventArgs e)
        {
            cbEpsc.Checked = true;
            nudEpscFreq.Value = 50;
            nudEpscAmp.Value = 5;
            cbEpsc_CheckedChanged(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            int thisStepSize = (cbSimulationSlow.Checked) ? 10 : 200;
            double thisStepTimeMs = thisStepSize * sim.stepSizeMs;
            double constantCurrent = (double)nudCurrentConstant.Value;
            double pulseCurrent = (pulseTimeRemaining > 0) ? (double)nudCurrentPulse.Value : 0;
            sim.StepForward(thisStepSize, constantCurrent + pulseCurrent);
            pulseTimeRemaining -= thisStepTimeMs;
            Array.Copy(sim.voltage.ToArray(), 0, voltage, 0, voltage.Length);
            formsPlot1.plt.Clear(signalPlots: false);
            formsPlot1.plt.PlotVLine(sim.voltageIndex / sim.sampleRateHz * 1000, color: Color.Red, lineWidth: 3);
            formsPlot1.Render(skipIfCurrentlyRendering: true);
            string formattedMessage = (cbSimulationSlow.Checked) ? "{0:0.000} sec" : "{0:0.00} sec";
            lblTime.Text = string.Format(formattedMessage, sim.totalRunTimeSec);
            //Application.DoEvents();
            timer1.Enabled = true;
        }

        private void cbSimulationRun_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = cbSimulationRun.Checked;
        }

        private void btnDeliverPulse_Click(object sender, EventArgs e)
        {
            pulseTimeRemaining = (double)nudPulseLengthMs.Value;
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
    }
}
