using Xunit;
using Pattern.SlidingWindow;

namespace Pattern.SlidingWindowTest
{
    public class UnitTest1
    {
        // Maximum Sum Subarray of Size K (easy)
        [Theory]
        [InlineData(3, new int[] { 2, 1, 5, 1, 3, 2 }, 9)]
        [InlineData(2, new int[] { 2, 3, 4, 1, 5 }, 7)]
        public void Test1(int k, int[] arr, int expected)
        {
            int result = MaxSumSubArrayOfSizeK.FindMaxSumSubArray(k, arr);
            Assert.Equal(expected, result);
        }

        // Smallest Subarray With a Greater Sum (easy)
        [Theory]
        [InlineData(7, new int[] { 2, 1, 5, 2, 3, 2 }, 2)]
        [InlineData(7, new int[] { 2, 1, 5, 2, 8 }, 1)]
        [InlineData(8, new int[] { 3, 4, 1, 1, 6 }, 3)]
        public void Test2(int S, int[] arr, int expected)
        {
            int result = MinSizeSubArraySum.FindMinSubArray(S, arr);
            Assert.Equal(expected, result);
        }

        //Longest Substring with maximum K Distinct Characters (medium)
        [Theory]
        [InlineData("araaci", 2, 4)]
        [InlineData("araaci", 1, 2)]
        [InlineData("cbbebi", 3, 5)]
        [InlineData("cbbebi", 10, 6)]
        public void Test3(string str, int k, int expected)
        {
            int result = LongestSubstringKDistinct.FindLength("araaci", 2);
            Assert.Equal(expected, result);
        }

        //// Fruits into Baskets (medium)
        //[Fact]
        //public void Test4()
        //{

        //    Assert.Equal(expected, result);
        //}
        //// Longest Substring with Distinct Characters (hard)
        //[Fact]
        //public void Test5()
        //{

        //    Assert.Equal(expected, result);
        //}
        //// Longest Substring with Same Letters after Replacement (hard)
        //[Fact]
        //public void Test6()
        //{

        //    Assert.Equal(expected, result);
        //}
        //// Longest Subarray with Ones after Replacement (hard)
        //[Fact]
        //public void Test7()
        //{

        //    Assert.Equal(expected, result);
        //}
        //// Problem Challenge 1
        //// Permutation in a String (hard)
        //[Fact]
        //public void Test8()
        //{

        //    Assert.Equal(expected, result);
        //}

        //// Problem Challenge 2
        //// String Anagrams (hard)
        //[Fact]
        //public void Test9()
        //{

        //    Assert.Equal(expected, result);
        //}

        //// Problem Challenge 3
        //// Smallest Window containing Substring (hard)
        //[Fact]
        //public void Test10()
        //{

        //    Assert.Equal(expected, result);
        //}

        //// Problem Challenge 4
        //// Words Concatenation (hard)
        //[Fact]
        //public void Test11()
        //{

        //    Assert.Equal(expected, result);
        //}
    }
}
