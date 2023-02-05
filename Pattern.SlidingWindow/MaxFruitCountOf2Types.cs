using System;
using System.Collections.Generic;

namespace Pattern.SlidingWindow
{
    /*
     You are visiting a farm to collect fruits. The farm has a single row of fruit trees. You will be given two baskets, and your goal is to pick as many fruits as possible to be placed in the given baskets.

You will be given an array of characters where each character represents a fruit tree. The farm has following restrictions:

Each basket can have only one type of fruit. There is no limit to how many fruit a basket can hold.
You can start with any tree, but you can’t skip a tree once you have started.
You will pick exactly one fruit from every tree until you cannot, i.e., you will stop when you have to pick from a third fruit type.
Write a function to return the maximum number of fruits in both baskets.
     */
    class MaxFruitCountOf2Types
    {
        //Time O(N) The algorithm runs in constant space O(1) as there can be a maximum of three types of fruits stored in the frequency map.
        public static int FindLength(char[] arr)
        {
            int longestSubstring = 0;
            int windowStart = 0;
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                if (charFrequency.ContainsKey(arr[windowEnd]))
                    charFrequency[arr[windowEnd]]++;
                else
                    charFrequency.Add(arr[windowEnd], 1);

                while (charFrequency.Count > 2)
                {
                    charFrequency[arr[windowStart]]--;
                    if (charFrequency[arr[windowStart]] == 0)
                        charFrequency.Remove(arr[windowStart]);
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
 * Similar Problems
Problem 1: Longest Substring with at most 2 distinct characters

Given a string, find the length of the longest substring in it with at most two distinct characters.

Solution: This problem is exactly similar to our parent problem.
 */