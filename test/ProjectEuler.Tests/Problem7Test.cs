using Xunit;

namespace ProjectEuler.Test
{

    public class Problem7Test
    {
        [Fact]
        public void PrimeFinder_LookingForSixth_ReturnsThirteen()
        {
            var seven = new Problem7();
            var output = seven.PrimeFinder(6);
            Assert.Equal(13, output);
        }

        [Fact]
        public void PrimeFinder_LookingForFirst_ReturnsTwo()
        {
            var seven = new Problem7();
            var output = seven.PrimeFinder(1);
            Assert.Equal(2, output);
        }
    }
}
