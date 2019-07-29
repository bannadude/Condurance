using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void SimpleTest()
        {
            Assert.That(false, "Pass");
        }
    }
}
