using Algorithms.Algorithms.Recursion;
using Xunit;

namespace AlgorithmsTest.Algorithms.Recursion
{
    public class RecursionTest
    {
        [Fact]
        public void PowerTest()
        {

            RecursionTool recursionTool = new RecursionTool();

            Assert.Equal(4, recursionTool.Power(2, 2));
            Assert.Equal(8, recursionTool.Power(2, 3));
            Assert.Equal(25, recursionTool.Power(5, 2));
            Assert.Equal(36, recursionTool.Power(6, 2));
            Assert.Equal(1, recursionTool.Power(7, 0));

            Assert.Equal(4, recursionTool.Power2(2, 2));
            Assert.Equal(8, recursionTool.Power2(2, 3));
            Assert.Equal(25, recursionTool.Power2(5, 2));
            Assert.Equal(36, recursionTool.Power2(6, 2));
            Assert.Equal(1, recursionTool.Power2(7, 0));
        }

        [Fact]
        public void FactorialTest()
        {
            RecursionTool recursionTool = new RecursionTool();

            Assert.Equal(120, recursionTool.Factorial(5));
            Assert.Equal(720, recursionTool.Factorial(6));
        }
    }
}
