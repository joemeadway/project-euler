using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace ProjectEulerTest
{
    [TestClass]
    public class Problem6Test
    {
        [TestMethod]
        public void SumOfSquares_MatchesGivenExample()
        {
            var six = new Problem6();
            var output = six.SumOfSquares(1, 10);
            Assert.AreEqual(385, output);
        }

        [TestMethod]
        public void SquareOfSum_MatchesGivenExample()
        {
            var six = new Problem6();
            var output = six.SquareOfSum(1, 10);
            Assert.AreEqual(3025, output);

        }
    }
}
