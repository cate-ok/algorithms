using System;

namespace Pattern.SlidingWindow
{
    public class MaxSumSubArrayOfSizeK
    {
        /* Given an array of positive numbers and a positive number ‘k,’ 
         * find the maximum sum of any contiguous subarray of size ‘k’ */

        // time complexity - O(N), space - O(1)
        public static int FindMaxSumSubArray(int k, int[] arr)
        {
            int maxSum = 0;
            int windowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd]; // add the next element
                if (windowEnd >= k-1)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum -= arr[windowStart];   // element outside window
                    windowStart++; // slide the window ahead
                }
            }
            return maxSum;
        }
    }
}
