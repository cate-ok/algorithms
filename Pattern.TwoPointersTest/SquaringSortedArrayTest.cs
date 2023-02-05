using Pattern.TwoPointers;
using Xunit;

namespace Pattern.TwoPointersTest
{
    public class SquaringSortedArrayTest
    {
        [Theory]
        [InlineData(new int[] { -2, -1, 0, 2, 3 }, new int[] { 0, 1, 4, 4, 9 })]
        [InlineData(new int[] { -3, -1, 0, 1, 2 }, new int[] { 0, 1, 1, 4, 9 })]
        public void Test1(int[] arr, int[] expected)
        {
            int[] result = SquaringSortedArray.MakeSquares(arr);
            Assert.Equal(expected, result);
        }
    }
}
