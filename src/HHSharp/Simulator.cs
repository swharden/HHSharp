using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public double epscAmplitude, epscFrequencyHz;
        public readonly List<double> epscs = new List<double>();
        public Random rand = new Random();

        public readonly double stepSizeMs = 0.05;
        public double sampleRateHz { get { return 1000.0 / stepSizeMs; } }

        public Simulator(double lengthMs = 500, double initialCurrent = 20, double stepSizeMs = 0.05)
        {
            int pointCount = (int)(lengthMs / stepSizeMs);
            this.stepSizeMs = stepSizeMs;
            voltage = new double[pointCount];
            StepForward(pointCount, initialCurrent);
        }

        private double EpscWaveform(double timeMs, double alpha = .1)
        {
            double current = Math.Pow(alpha, 2) * timeMs * Math.Exp(-alpha * timeMs) * 20;
            return current * epscAmplitude;
        }

        private double GetEpscCurrent()
        {
            // randomly add EPSCs
            if (epscFrequencyHz > 0)
                if (rand.Next((int)(sampleRateHz / epscFrequencyHz)) == 1)
                    epscs.Add(0);

            // remove old EPSCs
            double maxEpscLengthMs = 500;
            int maxEpscPoints = (int)(maxEpscLengthMs / stepSizeMs);
            while ((epscs.Count > 1) && (epscs.Last() > maxEpscPoints))
                epscs.RemoveAt(epscs.Count - 1);

            // summate EPSCs
            double current = 0;
            for (int i = 0; i < epscs.Count; i++)
            {
                epscs[i] = epscs[i] + 1;
                current += EpscWaveform(epscs[i] * stepSizeMs);
            }

            return current;
        }

        public void StepForward(int steps, double stimulusCurrent)
        {
            for (int i = 0; i < steps; i++)
            {
                model.StepForward(stimulusCurrent + GetEpscCurrent(), stepSizeMs);
                voltage[voltageIndex++] = model.Vm;
                if (voltageIndex >= voltage.Length) voltageIndex = 0;
            }
            totalRunTimeSec += steps * stepSizeMs / 1000.0;
        }
    }
}
