using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.FastAndSlowPointers
{
    class HappyNumber
    {
        // time complexity of O(logN) Space N(1)
        public static bool Find(int num)
        {
            int slow = num;
            int fast = num;
            do
            {
                slow = GetSumOfSquares(slow); // move one step
                fast = GetSumOfSquares(GetSumOfSquares(fast)); // move two steps
            }
            while (slow != fast); // found the cycle

            return slow == 1; // see if the cycle is stuck on the number '1'
        }

        private static int GetSumOfSquares(int num)
        {
            int sum = 0;
            string str = num.ToString();
            for (int i=0; i<str.Length; i++)
            {
                int a = (int)char.GetNumericValue(str[i]);
                sum += a * a;
            }
            return sum;
        }
    }
}
