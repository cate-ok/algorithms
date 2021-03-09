namespace Algorithms.Algorithms.Recursion
{
    public class RecursionTool
    {
        public int Power(int n, int p)
        {
            int result = 1;
            for(var i=0; i<p; i++)
            {
                result *= n;
            }
            return result;
        }

        public int Power2(int n, int p)
        {
            if (p == 0)
                return 1;
            else
                return n * Power2(n, p-1);           
        }

        // 5! = 5 * 4 * 3  *2 * 1 = 120
        // 0! = 1
        public int Factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
    }
}
