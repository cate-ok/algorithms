using System;
using System.Collections.Generic;

namespace Pattern.SlidingWindow
{
    /*
     * Given a string, find the length of the longest substring in it with no more than K distinct characters.
     */

    public class LongestSubstringKDistinct
    {
        // Time O(N) space complexity is O(K) , as we will be storing a maximum of K+1 characters in the HashMap.
        public static int FindLength(string str, int k)
        {                                                                                                                          
            int longestSubstring = 0;
            int windowStart = 0;
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            for(int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {                
                if (charFrequency.ContainsKey(str[windowEnd]))
                    charFrequency[str[windowEnd]]++;
                else
                    charFrequency.Add(str[windowEnd], 1);

                while (charFrequency.Count > k)
                {
                    charFrequency[str[windowStart]]--;
                    if (charFrequency[str[windowStart]] == 0)
                        charFrequency.Remove(str[windowStart]);
                    windowStart++;
                }
                int windowSize = windowEnd - windowStart + 1;
                longestSubstring = Math.Max(longestSubstring, windowSize);
            }
            return longestSubstring;
        }
    }
}

/*
 */
