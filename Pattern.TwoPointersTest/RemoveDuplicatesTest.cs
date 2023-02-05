using Pattern.TwoPointers;
using Xunit;

namespace Pattern.TwoPointersTest
{
    public class RemoveDuplicatesTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 3, 3, 6, 9, 9 }, 4)]
        [InlineData(new int[] { 2, 2, 2, 11 }, 2)]
        public void Test1(int[] arr, int expected)
        {
            int result = RemoveDuplicates.Remove(arr);
            Assert.Equal(expected, result);
        }
    }
}
