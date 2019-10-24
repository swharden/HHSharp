using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace HHSharp
{
    public class Simulator
    {
        public readonly HHModel model = new HHModel();

        public readonly double[] voltage;
        public int voltageIndex;

        public double totalRunTimeSec, stepSizeMs;

        public double sampleRateHz { get { return 1000.0 / stepSizeMs; } }
        public bool slowMotion = false;

        public double constantCurrent;
        public double squarePulseAmplitude, squarePulseMsRemaining;
        public Random rand = new Random();
        public double epscAmplitude, epscFrequencyHz;
        public readonly List<double> epscs = new List<double>();

        public Timer timer;

        public Simulator(double lengthMs = 1000, double constantCurrent = 0, double stepSizeMs = 0.05)
        {
            int pointCount = (int)(lengthMs / stepSizeMs);
            this.stepSizeMs = stepSizeMs;
            this.constantCurrent = constantCurrent;

            voltage = new double[pointCount];
            StepForward(pointCount);

            timer = new Timer(10);
            timer.Elapsed += new ElapsedEventHandler(OnTimerTick);
            timer.Start();
        }

        private void OnTimerTick(object source, ElapsedEventArgs e)
        {
            int stepsPerTick = (int)(timer.Interval / stepSizeMs);
            if (slowMotion) stepsPerTick /= 50;
            StepForward(stepsPerTick);
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

            // advance EPSC times
            for (int i = 0; i < epscs.Count; i++)
                epscs[i] = epscs[i] + 1;

            // summate EPSCs
            double current = 0;
            for (int i = 0; i < epscs.Count; i++)
                current += EpscWaveform(epscs[i] * stepSizeMs);

            return current;
        }

        private double GetSquarePulseCurrent()
        {
            double current = (squarePulseMsRemaining > 0) ? squarePulseAmplitude : 0;
            squarePulseMsRemaining -= stepSizeMs;
            return current;
        }

        public void StepForward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                double stimulus = constantCurrent + GetEpscCurrent() + GetSquarePulseCurrent();
                model.StepForward(stimulus, stepSizeMs);
                voltage[voltageIndex++] = model.Vm;
                if (voltageIndex >= voltage.Length) voltageIndex = 0;
            }
            totalRunTimeSec += steps * stepSizeMs / 1000.0;
        }
    }
}
