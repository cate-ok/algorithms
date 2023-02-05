using Pattern.TwoPointers;
using Xunit;

namespace Pattern.TwoPointersTest
{
    public class SumOfThreeTest
    {
        [Theory]
        [InlineData(new int[] { 1, -1, 0 }, 1, false)]
        [InlineData(new int[] { 1, -1, 0 }, -1, false)]
        [InlineData(new int[] { 1, -1, 0 }, 0, true)]
        [InlineData(new int[] { 3, 7, 1, 2, 8, 4, 5 }, 10, true)]
        [InlineData(new int[] { 3, 7, 1, 2, 8, 4, 5 }, 20, true)]
        [InlineData(new int[] { 3, 7, 1, 2, 8, 4, 5 }, 21, false)]
        [InlineData(new int[] { -1, 2, 1, -4, 5, -3 }, -8, true)]
        [InlineData(new int[] { -1, 2, 1, -4, 5, -3 }, 0, true)]
        [InlineData(new int[] { -1, 2, 1, -4, 5, -3 }, 7, false)]
        [InlineData(new int[] { 2, 3, 4, 1, 7, 9 }, 8, true)]
        [InlineData(new int[] { 2, 3, 4, 1, 7, 9 }, 10, true)]
        [InlineData(new int[] { 2, 3, 4, 1, 7, 9 }, 20, true)]
        [InlineData(new int[] { 2, 4, 2, 7, 6, 3, 1 }, 8, true)]
        [InlineData(new int[] { 2, 4, 2, 7, 6, 3, 1 }, 11, true)]
        [InlineData(new int[] { 2, 4, 2, 7, 6, 3, 1 }, 15, true)]
        public void Test1(int[] nums, int target, bool expected)
        {
            bool result = SumOfThree.FindSumOfThree(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
