using Xunit;
using Algorithms.Algorithms.Logic;

namespace AlgorithmsTest.Algorithms.Logic
{
    public class MathPuzzleTest
    {
        [Fact]
        public void IsPrimeTest()
        {
            var mathPuzzle = new MathPuzzle();

            Assert.False(mathPuzzle.IsPrime(1));
            Assert.True(mathPuzzle.IsPrime(2));
            Assert.True(mathPuzzle.IsPrime(3));
            Assert.True(mathPuzzle.IsPrime(5));
            Assert.False(mathPuzzle.IsPrime(9));
            Assert.False(mathPuzzle.IsPrime(10));
            Assert.True(mathPuzzle.IsPrime(13));
            Assert.False(mathPuzzle.IsPrime(15));
            Assert.True(mathPuzzle.IsPrime(17));
            Assert.True(mathPuzzle.IsPrime(29));
        }

    }
}
