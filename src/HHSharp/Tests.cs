using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHSharp
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void VerifySimulationValues()
        {
            // simulate constant excitatory current for 50ms
            var hh = new HHModel();
            for (int i = 0; i < 5_000; i++)
                hh.Iterate(stimulusCurrent: 20, deltaTms: 0.01);

            // ensure all values match what we expect
            Assert.That(hh.Vm, Is.EqualTo(25.3868376949024).Within(0.0001));
            Assert.That(hh.m.alpha, Is.EqualTo(1.04329640337898).Within(0.0001));
            Assert.That(hh.m.beta, Is.EqualTo(0.951203951792703).Within(0.0001));
            Assert.That(hh.n.alpha, Is.EqualTo(0.199386100874345).Within(0.0001));
            Assert.That(hh.n.beta, Is.EqualTo(0.0904811444841807).Within(0.0001));
            Assert.That(hh.h.alpha, Is.EqualTo(0.0192172096954907).Within(0.0001));
            Assert.That(hh.h.beta, Is.EqualTo(0.397804384343861).Within(0.0001));
        }
    }
}
