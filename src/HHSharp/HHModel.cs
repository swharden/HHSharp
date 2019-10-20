using System;

namespace HHSharp
{
    public struct Gate
    {
        public double alpha, beta, state;
        public void Update(double deltaTms) { state += deltaTms * ((alpha * (1 - state)) - (beta * state)); }
        public void SetInfiniteState() { state = alpha / (alpha + beta); }
    }

    public class HHModel
    {
        public double ENa = 115;
        public double EK = -12;
        public double EKleak = 10.6;
        public double gNa = 120;
        public double gK = 36;
        public double gKleak = 0.3;
        public double Cm = 1;
        public double Vm;

        public Gate m = new Gate();
        public Gate n = new Gate();
        public Gate h = new Gate();

        public HHModel(double startingVoltage = 0)
        {
            Vm = startingVoltage;
            UpdateGateTimeConstants(startingVoltage);
            m.SetInfiniteState();
            n.SetInfiniteState();
            n.SetInfiniteState();
        }

        public void UpdateGateTimeConstants(double Vm)
        {
            n.alpha = .01 * ((10 - Vm) / (Math.Exp((10 - Vm) / 10) - 1));
            n.beta = .125 * Math.Exp(-Vm / 80);
            m.alpha = .1 * ((25 - Vm) / (Math.Exp((25 - Vm) / 10) - 1));
            m.beta = 4 * Math.Exp(-Vm / 18);
            h.alpha = .07 * Math.Exp(-Vm / 20);
            h.beta = 1 / (Math.Exp((30 - Vm) / 10) + 1);
        }

        public void UpdateCellVoltage(double stimulusCurrent, double deltaTms)
        {
            double INa = Math.Pow(m.state, 3) * gNa * h.state * (Vm - ENa);
            double IK = Math.Pow(n.state, 4) * gK * (Vm - EK);
            double IKleak = gKleak * (Vm - EKleak);
            double Isum = stimulusCurrent - INa - IK - IKleak;
            Vm += deltaTms * Isum / Cm;
        }

        public void UpdateGateStates(double deltaTms)
        {
            n.Update(deltaTms);
            m.Update(deltaTms);
            h.Update(deltaTms);
        }

        public void Iterate(double stimulusCurrent = 0, double deltaTms = 0.05)
        {
            UpdateGateTimeConstants(Vm);
            UpdateCellVoltage(stimulusCurrent, deltaTms);
            UpdateGateStates(deltaTms);
        }
    }
}
