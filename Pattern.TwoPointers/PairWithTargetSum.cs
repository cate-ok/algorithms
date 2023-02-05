using System;

namespace Pattern.TwoPointers
{
    // 
    // Given an array of sorted numbers and a target sum, find a pair in the array whose sum is equal to the given target. Return their indices
    // 
    public class PairWithTargetSum
    {
        // Time O(N) Space O(1)
        public static int[] Search(int[] arr, int targetSum)
        {
            int p1 = 0;
            int p2 = arr.Length - 1;
            int sum = 0;
            while (p1 < p2)
            {
                sum = arr[p1] + arr[p2];
                if (sum == targetSum)
                    return new int[] { p1, p2 };

                if (sum < targetSum)
                    p1++;
                else
                    p2--;
            }
            return new int[] { -1, -1 };
        }
    }
}
