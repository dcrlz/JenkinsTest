using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JenkinsTests
{
    [TestFixture]
    public class SampleTests
    {
        [Test]
        public void SumTwoValues()
        {
            var sum = 2 + 2;

            Assert.AreEqual(4, sum);
        }
    }
}
