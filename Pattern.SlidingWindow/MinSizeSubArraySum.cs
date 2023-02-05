using System;

namespace Pattern.SlidingWindow
{
    /*
     Given an array of positive integers and a number ‘S,’ 
    find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. 
    Return 0 if no such subarray exists.
     */
    public class MinSizeSubArraySum
    {
        // time complexity - O(N), space - O(1) 
        public static int FindMinSubArray(int S, int[] arr)
        {
            int smallestWindow = int.MaxValue;
            int windowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd]; // add the next element
                while (windowSum >= S) // Shrink the window as small as possible until the 'windowSum' is smaller than 'K'
                {
                    int windowSize = windowEnd - windowStart + 1;
                    smallestWindow = Math.Min(windowSize, smallestWindow);
                    windowSum -= arr[windowStart];   // element outside window
                    windowStart++; // slide the window ahead
                }
            }
            return smallestWindow;
        }
    }
}
