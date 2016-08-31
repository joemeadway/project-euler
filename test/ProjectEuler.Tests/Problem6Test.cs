using Xunit;

namespace ProjectEuler.Test
{
    public class Problem6Test
    {
        [Fact]
        public void SumOfSquares_MatchesGivenExample()
        {
            var six = new Problem6();
            var output = six.SumOfSquares(1, 10);
            Assert.Equal(385, output);
        }
        
        [Fact]
        public void SquareOfSum_MatchesGivenExample()
        {
            var six = new Problem6();
            var output = six.SquareOfSum(1, 10);
            Assert.Equal(3025, output);
        }
       
    }
}
