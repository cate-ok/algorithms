using Algorithms.Algorithms.String;
using Xunit;

namespace AlgorithmsTest.Algorithms.String
{
    public class StringAlgorithmsTest
    {
        [Fact]
        public void IsPalindromeTest()
        {
            string str1 = "caltotlac";
            string str2 = "Anna";
            string str3 = "Borrow or rob";

            var stringAlgorithms = new StringAlgorithms();

            Assert.True(stringAlgorithms.IsPalindrome(str1));
            Assert.True(stringAlgorithms.IsPalindrome(str2));
            Assert.True(stringAlgorithms.IsPalindrome(str3));
        }

        [Fact]
        public void CheckPermutationTest()
        {
            var stringAlgorithms = new StringAlgorithms();

            string str1 = "atbskb";
            string str2 = "tbbksa";

            Assert.True(stringAlgorithms.CheckPermutation(str1, str2));

        }
    }
}
