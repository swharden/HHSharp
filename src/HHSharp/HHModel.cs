using System;

namespace HHSharp
{
    public abstract class VoltageDependentGate
    {
        public double alpha, beta, activity;
        public override string ToString() { return $"alpha={alpha}, beta={beta}, activity={activity}"; }
        public void StepForward(double ms) { activity += ms * ((alpha * (1 - activity)) - (beta * activity)); }
        public void SetInfiniteState() { activity = alpha / (alpha + beta); }
        public abstract void UpdateTimeConstants(double Vm);

    }

    public class MGate : VoltageDependentGate // voltage-gated sodium channel activation gate
    {
        public override void UpdateTimeConstants(double Vm)
        {
            alpha = .1 * ((25 - Vm) / (Math.Exp((25 - Vm) / 10) - 1));
            beta = 4 * Math.Exp(-Vm / 18);
        }
    }

    public class HGate : VoltageDependentGate // voltage-gated sodium channel inactivation gate
    {
        public override void UpdateTimeConstants(double Vm)
        {
            alpha = .07 * Math.Exp(-Vm / 20);
            beta = 1 / (Math.Exp((30 - Vm) / 10) + 1);
        }
    }

    public class NGate : VoltageDependentGate // voltage-gated potassium channel activation gate
    {
        public override void UpdateTimeConstants(double Vm)
        {
            alpha = .01 * ((10 - Vm) / (Math.Exp((10 - Vm) / 10) - 1));
            beta = .125 * Math.Exp(-Vm / 80);
        }
    }

    public class HHModel
    {
        public double ENa = 115, EK = -12, EKleak = 10.6;
        public double gNa = 120, gK = 36, gKleak = 0.3;
        public double Cm = 1, Vm = 0;

        public VoltageDependentGate m = new MGate(), h = new HGate(), n = new NGate();

        public HHModel(double startingVoltage = 0)
        {
            Vm = startingVoltage;
            UpdateGateTimeConstants(startingVoltage);
            m.SetInfiniteState();
            h.SetInfiniteState();
            n.SetInfiniteState();
        }

        public override string ToString() { return $"Vm={Vm}\nm gate: {m}\nh gate: {h}\nn gate: {n}"; }

        public void UpdateGateTimeConstants(double Vm)
        {
            m.UpdateTimeConstants(Vm);
            h.UpdateTimeConstants(Vm);
            n.UpdateTimeConstants(Vm);
        }

        public void UpdateCellVoltage(double stimulusCurrent, double deltaTms)
        {
            double INa = Math.Pow(m.activity, 3) * gNa * h.activity * (Vm - ENa);
            double IK = Math.Pow(n.activity, 4) * gK * (Vm - EK);
            double IKleak = gKleak * (Vm - EKleak);
            double Isum = stimulusCurrent - INa - IK - IKleak;
            Vm += deltaTms * Isum / Cm;
        }

        public void UpdateGateStates(double deltaTms)
        {
            m.StepForward(deltaTms);
            h.StepForward(deltaTms);
            n.StepForward(deltaTms);
        }

        public void Iterate(double stimulusCurrent = 0, double deltaTms = 0.05)
        {
            UpdateGateTimeConstants(Vm);
            UpdateCellVoltage(stimulusCurrent, deltaTms);
            UpdateGateStates(deltaTms);
        }
    }
}
