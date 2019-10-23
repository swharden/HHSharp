using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHSharp
{
    public class Simulator
    {
        public readonly HHModel model = new HHModel();
        public readonly double[] voltage;
        public int voltageIndex;
        public double totalRunTimeSec;

        public readonly double stepSizeMs = 0.05;
        public double sampleRate { get { return 1.0 / stepSizeMs; } }

        public Simulator(double lengthMs = 500, double initialCurrent = 20, double stepSizeMs = 0.05)
        {
            int pointCount = (int)(lengthMs / stepSizeMs);
            this.stepSizeMs = stepSizeMs;
            voltage = new double[pointCount];
            StepForward(pointCount, initialCurrent);
        }

        public void StepForward(int steps, double stimulusCurrent)
        {
            for (int i = 0; i < steps; i++)
            {
                model.StepForward(stimulusCurrent, stepSizeMs);
                voltage[voltageIndex++] = model.Vm;
                if (voltageIndex >= voltage.Length) voltageIndex = 0;
            }
            totalRunTimeSec += steps * stepSizeMs / 1000.0;
        }
    }
}
