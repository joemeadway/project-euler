using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace ProjectEulerTest
{

    [TestClass]
    public class Problem7Test
    {
        [TestMethod]
        public void PrimeFinder_LookingForSixth_ReturnsThirteen()
        {
            var seven = new Problem7();
            var output = seven.PrimeFinder(6);
            Assert.AreEqual(13, output);
        }

        [TestMethod]
        public void PrimeFinder_LookingForFirst_ReturnsTwo()
        {
            var seven = new Problem7();
            var output = seven.PrimeFinder(1);
            Assert.AreEqual(2, output);
        }
    }
}
