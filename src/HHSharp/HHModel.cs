// Hodgkin-Huxley neuron simulator by Scott W Harden
// Equations reference Hodgkin & Huxley (1952) https://www.ncbi.nlm.nih.gov/pmc/articles/PMC1392413/

using System;

namespace HHSharp
{
    public abstract class VoltageGate
    {
        public double alpha; // rate of opening (units = fraction / millisecond)
        public double beta; // rate of closing (units = fraction / millisecond)
        public double activation; // activation fraction (range 0-1)
        public double activationChangePerMs { get { return alpha * (1 - activation) - beta * activation; } }
        public abstract void UpdateTimeConstants(double Vm);
        public override string ToString() { return $"alpha={alpha}, beta={beta}, activation={activation}"; }
        public void SetInfiniteState() { activation = alpha / (alpha + beta); }
        public void StepForward(double stepSizeMs) { activation += activationChangePerMs * stepSizeMs; }
    }

    public class VgscActivationGate : VoltageGate
    {
        public override void UpdateTimeConstants(double Vm)
        {
            alpha = .1 * ((25 - Vm) / (Math.Exp((25 - Vm) / 10) - 1)); // Hodgkin & Huxley (1952) Equation 20
            beta = 4 * Math.Exp(-Vm / 18); // Hodgkin & Huxley (1952) Equation 21
        }
    }

    public class VgscInactivationGate : VoltageGate
    {
        public override void UpdateTimeConstants(double Vm)
        {
            alpha = .07 * Math.Exp(-Vm / 20); // Hodgkin & Huxley (1952) Equation 23
            beta = 1 / (Math.Exp((30 - Vm) / 10) + 1); // Hodgkin & Huxley(1952) Equation 24
        }
    }

    public class VgkcActivationGate : VoltageGate
    {
        public override void UpdateTimeConstants(double Vm)
        {
            alpha = .01 * ((10 - Vm) / (Math.Exp((10 - Vm) / 10) - 1)); // Hodgkin & Huxley (1952) Equation 12
            beta = .125 * Math.Exp(-Vm / 80); // Hodgkin & Huxley (1952) Equation 13
        }
    }

    public class HHModel
    {
        public double ENa = 115, EK = -12, EKleak = 10.6; // Hodgkin & Huxley (1952) Table 3 (units = mV)
        public double gNa = 120, gK = 36, gKleak = 0.3; // Hodgkin & Huxley (1952) Table 3 (units = mS/cm²)
        public double Cm = 1; // Hodgkin & Huxley (1952) Table 3 (units = µF/cm²)

        public VoltageGate m = new VgscActivationGate();
        public VoltageGate h = new VgscInactivationGate();
        public VoltageGate n = new VgkcActivationGate();

        public HHModel(double initialVoltageOffset = 0)
        {
            Vm = initialVoltageOffset;
            UpdateAllGateTimeConstants(Vm);
            m.SetInfiniteState();
            h.SetInfiniteState();
            n.SetInfiniteState();
        }

        public override string ToString()
        {
            return $"Vm={Vm}\nm gate: {m}\nh gate: {h}\nn gate: {n}\nINa={INa}\nIK={IK}\nIKleak={IKleak}";
        }

        private void UpdateAllGateTimeConstants(double Vm)
        {
            m.UpdateTimeConstants(Vm);
            h.UpdateTimeConstants(Vm);
            n.UpdateTimeConstants(Vm);
        }

        public double INa, IK, IKleak, Isum; // (units = µA/cm²)
        public double Vm; // (units = mV)
        private void UpdateCurrentsAndVoltage(double stimulusCurrent, double deltaTms) // Hodgkin & Huxley (1952) equation 33
        {
            INa = Math.Pow(m.activation, 3) * gNa * h.activation * (Vm - ENa);
            IK = Math.Pow(n.activation, 4) * gK * (Vm - EK);
            IKleak = gKleak * (Vm - EKleak);
            Isum = stimulusCurrent - INa - IK - IKleak;
            Vm += deltaTms * Isum / Cm;
        }

        public void StepForward(double stimulusCurrent, double stepSizeMs)
        {
            UpdateAllGateTimeConstants(Vm);
            UpdateCurrentsAndVoltage(stimulusCurrent, stepSizeMs);
            m.StepForward(stepSizeMs);
            h.StepForward(stepSizeMs);
            n.StepForward(stepSizeMs);
        }
    }
}
