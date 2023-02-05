﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.SlidingWindow
{
    /*
     * Given an array containing 0s and 1s, if you are allowed to replace no more than ‘k’ 0s with 1s, find the length of the longest contiguous subarray having all 1s.
 */
    class ReplacingOnes
    {
        // // time complexity - O(N), space - O(1)
        public static int FindLength(int[] arr, int k)
        {
            // TODO: Write your code here
            return -1;
        }
    }
}
/*
 * 
 * public static int findLength(int[] arr, int k) {
    int windowStart = 0, maxLength = 0, maxOnesCount = 0;
    // try to extend the range [windowStart, windowEnd]
    for (int windowEnd = 0; windowEnd < arr.length; windowEnd++) {
      if (arr[windowEnd] == 1)
        maxOnesCount++;

      // current window size is from windowStart to windowEnd, overall we have a maximum of 1s
      // repeating a maximum of 'maxOnesCount' times, this means that we can have a window with
      // 'maxOnesCount' 1s and the remaining are 0s which should replace with 1s.
      // now, if the remaining 0s are more than 'k', it is the time to shrink the window as we
      // are not allowed to replace more than 'k' Os
      if (windowEnd - windowStart + 1 - maxOnesCount > k) {
        if (arr[windowStart] == 1)
          maxOnesCount--;
        windowStart++;
      }

      maxLength = Math.max(maxLength, windowEnd - windowStart + 1);
    }

    return maxLength;
  }
 */
