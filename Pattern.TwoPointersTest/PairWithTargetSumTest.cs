using Pattern.TwoPointers;
using Xunit;

namespace Pattern.TwoPointersTest
{
    public class PairWithTargetSumTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 6 }, 6, new int[] { 1, 3 })]
        [InlineData(new int[] { 2, 5, 9, 11 }, 11, new int[] { 0, 2 })]
        public void Test1(int[] arr, int targetSum, int[] expected)
        {
            int[] result = PairWithTargetSum.Search(arr, targetSum);
            Assert.Equal(expected, result);
        }
    }
}
