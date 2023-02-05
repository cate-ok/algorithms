using Pattern.TwoPointers;
using Xunit;

namespace Pattern.TwoPointersTest
{
    public class ReverseWordsTest
    {
        [Theory]
        [InlineData("Hello World!", "World! Hello")]
        [InlineData("We love Python.", "Python. love We")]
        [InlineData("The quick brown fox jumped over the lazy dog.", "dog. lazy the over jumped fox brown quick The")]
        [InlineData("Hey!", "Hey!")]
        [InlineData("To be, or not to be", "be to not or be, To")]
        [InlineData("AAAAA", "AAAAA")]
        [InlineData("Hello     World", "World Hello")]
        public void Test1(string s, string expected)
        {
            string result = ReverseWords.Reverse(s);
            Assert.Equal(expected, result);
        }
    }
}