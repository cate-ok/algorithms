using System;

namespace Algorithms.Algorithms.Logic
{
    public class MathPuzzle
    {
        public bool IsPrime(int x)
        {
            if (x < 2)
            {
                return false;
            }                
            int sqrt = (int)Math.Sqrt(x);
            for (var i=2; i<sqrt+1; i++)
            {
                if (x % i == 0)
                { 
                    return false;
                }
            }
            return true;
        }
    }
}
