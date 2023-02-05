using System;
using System.Collections.Generic;

namespace Pattern.SlidingWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Maximum Sum Subarray of Size K (easy)
            //Console.WriteLine("Maximum sum of a subarray of size K: " + 
            //    MaxSumSubArrayOfSizeK.FindMaxSumSubArray(3, new int[] { 2, 1, 5, 1, 3, 2 }));
            //Console.WriteLine("Maximum sum of a subarray of size K: " +
            //    MaxSumSubArrayOfSizeK.FindMaxSumSubArray(2, new int[] { 2, 3, 4, 1, 5 }));
            //Console.WriteLine("----------");

            //// Smallest Subarray With a Greater Sum (easy)
            //int result = MinSizeSubArraySum.FindMinSubArray(7, new int[] { 2, 1, 5, 2, 3, 2 });
            //Console.WriteLine("Smallest subarray length: " + result);
            //result = MinSizeSubArraySum.FindMinSubArray(8, new int[] { 3, 4, 1, 1, 6 });
            //Console.WriteLine("Smallest subarray length: " + result);
            //result = MinSizeSubArraySum.FindMinSubArray(8, new int[] { 2, 1, 5, 2, 3, 2 });
            //Console.WriteLine("Smallest subarray length: " + result);
            //Console.WriteLine("----------");

            //Longest Substring with maximum K Distinct Characters (medium)
            Console.WriteLine("Length of the longest substring: " + LongestSubstringKDistinct.FindLength("araaci", 2)); // 4
            Console.WriteLine("Length of the longest substring: " + LongestSubstringKDistinct.FindLength("araaci", 1)); // 2
            Console.WriteLine("Length of the longest substring: " + LongestSubstringKDistinct.FindLength("cbbebi", 3)); // 5
            Console.WriteLine("----------");

            // Fruits into Baskets (medium)

            Console.WriteLine("Maximum number of fruits: " + MaxFruitCountOf2Types.FindLength(new char[] { 'A', 'B', 'C', 'A', 'C' }));
            Console.WriteLine("Maximum number of fruits: " + MaxFruitCountOf2Types.FindLength(new char[] { 'A', 'B', 'C', 'B', 'B', 'C' }));
            Console.WriteLine("----------");

            // Longest Substring with Distinct Characters (hard)
            //System.out.println("Length of the longest substring: " + NoRepeatSubstring.findLength("aabccbb"));
            //System.out.println("Length of the longest substring: " + NoRepeatSubstring.findLength("abbbb"));
            //System.out.println("Length of the longest substring: " + NoRepeatSubstring.findLength("abccde"));
            Console.WriteLine("----------");

            // Longest Substring with Same Letters after Replacement (hard)
            //System.out.println(CharacterReplacement.findLength("aabccbb", 2));
            //System.out.println(CharacterReplacement.findLength("abbcb", 1));
            //System.out.println(CharacterReplacement.findLength("abccde", 1));
            Console.WriteLine("----------");

            // Longest Subarray with Ones after Replacement (hard)
            Console.WriteLine(ReplacingOnes.FindLength(new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1 }, 2));
            Console.WriteLine(ReplacingOnes.FindLength(new int[] { 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1 }, 3));
            Console.WriteLine("----------");

            // Problem Challenge 1
            // Permutation in a String (hard)
            Console.WriteLine("Permutation exist: " + StringPermutation.FindPermutation("oidbcaf", "abc"));
            Console.WriteLine("Permutation exist: " + StringPermutation.FindPermutation("odicf", "dc"));
            Console.WriteLine("Permutation exist: " + StringPermutation.FindPermutation("bcdxabcdy", "bcdyabcdx"));
            Console.WriteLine("Permutation exist: " + StringPermutation.FindPermutation("aaacb", "abc"));
            Console.WriteLine("----------");

            // Problem Challenge 2
            // String Anagrams (hard)
            Console.WriteLine(StringAnagrams.FindStringAnagrams("ppqp", "pq"));
            Console.WriteLine(StringAnagrams.FindStringAnagrams("abbcabc", "abc"));
            Console.WriteLine("----------");

            // Problem Challenge 3
            // Smallest Window containing Substring (hard)
            Console.WriteLine(MinimumWindowSubstring.FindSubstring("aabdec", "abc"));
            Console.WriteLine(MinimumWindowSubstring.FindSubstring("aabdec", "abac"));
            Console.WriteLine(MinimumWindowSubstring.FindSubstring("abdbca", "abc"));
            Console.WriteLine(MinimumWindowSubstring.FindSubstring("adcad", "abc"));
            Console.WriteLine("----------");

            // Problem Challenge 4
            // Words Concatenation (hard)
            List<int> result2 = WordConcatenation.FindWordConcatenation("catfoxcat", new String[] { "cat", "fox" });
            Console.WriteLine(result2);
            result2 = WordConcatenation.FindWordConcatenation("catcatfoxfox", new String[] { "cat", "fox" });
            Console.WriteLine(result2);
        }
    }
}
