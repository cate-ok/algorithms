using Pattern.TwoPointers;
using Xunit;

namespace Pattern.TwoPointersTest
{
    public class ValidPalindromeTest
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        [InlineData("RACEACAR", false)]
        [InlineData("A", true)]
        [InlineData("ABCDABCD", false)]
        [InlineData("DCBAABCD", true)]
        [InlineData("ABCBA", true)]
        public void Test1(string s, bool expected)
        {
            bool result = ValidPalindrome.IsPalindrome(s);
            Assert.Equal(expected, result);
        }
    }
}
