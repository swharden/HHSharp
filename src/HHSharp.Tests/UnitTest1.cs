using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HHSharp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private bool CloseEnough(double a, double b, double within = 0.0000001)
        {
            return Math.Abs(a - b) < within;
        }

        [TestMethod]
        public void Test_HHModel_VerifySimulationValues()
        {
            // interact with the model directly
            var model = new HHModel();

            // simulate constant excitatory current for 50ms
            int iterations = 5_000;
            for (int i = 0; i < iterations; i++)
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

            Assert.IsTrue(CloseEnough(model.INa, -184.843379721599));
            Assert.IsTrue(CloseEnough(model.IK, 261.831569991066));
            Assert.IsTrue(CloseEnough(model.IKleak, 0.633203138741839));
        }

        [TestMethod]
        public void Test_Simulator_VerifySimulationValues()
        {
            // run a simulation and verify the results are accurate (assume is Vm is accurate, the rest are too)
            var sim = new Simulator(lengthMs: 50, constantCurrent: 20, stepSizeMs: 0.01, start: false);
            Console.WriteLine(sim);
            Assert.IsTrue(CloseEnough(sim.voltage[sim.voltage.Length - 1], 12.1344631950574));
        }
    }
}
