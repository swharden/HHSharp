using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HHSharp
{
    [TestClass]
    public class Tests
    {
        private bool CloseEnough(double a, double b, double within = 0.00001)
        {
            return Math.Abs(a - b) < within;
        }

        [TestMethod]
        public void VerifySimulationValues()
        {
            // simulate constant excitatory current for 50ms
            var model = new HHModel();
            for (int i = 0; i < 5_000; i++)
                model.StepForward(stimulusCurrent: 20, stepSizeMs: 0.01);

            Console.WriteLine(model);

            Assert.IsTrue(CloseEnough(model.Vm, 12.1344631950574));

            Assert.IsTrue(CloseEnough(model.m.alpha, 0.508331886190113));
            Assert.IsTrue(CloseEnough(model.m.beta, 1.97416521237869));
            Assert.IsTrue(CloseEnough(model.m.activation, 0.598998710210472));

            Assert.IsTrue(CloseEnough(model.h.alpha, 0.0370756858036909));
            Assert.IsTrue(CloseEnough(model.h.beta, 0.150724202887592));
            Assert.IsTrue(CloseEnough(model.h.activation, 0.0669057252257422));

            Assert.IsTrue(CloseEnough(model.n.alpha, 0.114164951305969));
            Assert.IsTrue(CloseEnough(model.n.beta, 0.106636971180963));
            Assert.IsTrue(CloseEnough(model.n.activation, 0.73607630180196));
        }
    }
}
