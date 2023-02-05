using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.SlidingWindow
{
    /*
     * Given a string with lowercase letters only, if you are allowed to replace no more than k letters with any letter, find the length of the longest substring having the same letters after replacement.
 */

    class CharacterReplacement
    {

        // time O (N)
        // As we expect only the lower case letters in the input string, we can conclude that the space complexity will be O(26)
        // // to store each letter’s frequency in the HashMap, which is asymptotically equal to O(1)

        //public static int findLength(String str, int k)
        //{
        //    int windowStart = 0, maxLength = 0, maxRepeatLetterCount = 0;
        //    Map<Character, Integer> letterFrequencyMap = new HashMap<>();
        //    // try to extend the range [windowStart, windowEnd]
        //    for (int windowEnd = 0; windowEnd < str.length(); windowEnd++)
        //    {
        //        char rightChar = str.charAt(windowEnd);
        //        letterFrequencyMap.put(rightChar, letterFrequencyMap.getOrDefault(rightChar, 0) + 1);

        //        // we don't need to place the maxRepeatLetterCount under the below 'if', see the 
        //        // explanation in the 'Solution' section above.
        //        maxRepeatLetterCount = Math.max(maxRepeatLetterCount, letterFrequencyMap.get(rightChar));

        //        // current window size is from windowStart to windowEnd, overall we have a letter which is
        //        // repeating 'maxRepeatLetterCount' times, this means we can have a window which has one letter 
        //        // repeating 'maxRepeatLetterCount' times and the remaining letters we should replace.
        //        // if the remaining letters are more than 'k', it is the time to shrink the window as we
        //        // are not allowed to replace more than 'k' letters
        //        if (windowEnd - windowStart + 1 - maxRepeatLetterCount > k)
        //        {
        //            char leftChar = str.charAt(windowStart);
        //            letterFrequencyMap.put(leftChar, letterFrequencyMap.get(leftChar) - 1);
        //            windowStart++;
        //        }

        //        maxLength = Math.max(maxLength, windowEnd - windowStart + 1);
        //    }

        //    return maxLength;
        //}
    }
}
/*
 */
