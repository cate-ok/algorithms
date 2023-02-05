using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.SlidingWindow
{
    /*
     * Given a string, find the length of the longest substring, which has all distinct characters.
 */

    class NoRepeatSubstring
    {
        // O(N) time
        //public static int findLength(String str)
        //{
        //    int windowStart = 0, maxLength = 0;
        //    Map<Character, Integer> charIndexMap = new HashMap<>();
        //    // try to extend the range [windowStart, windowEnd]
        //    for (int windowEnd = 0; windowEnd < str.length(); windowEnd++)
        //    {
        //        char rightChar = str.charAt(windowEnd);
        //        // if the map already contains the 'rightChar', shrink the window from the beginning so that
        //        // we have only one occurrence of 'rightChar'
        //        if (charIndexMap.containsKey(rightChar))
        //        {
        //            // this is tricky; in the current window, we will not have any 'rightChar' after its previous index
        //            // and if 'windowStart' is already ahead of the last index of 'rightChar', we'll keep 'windowStart'
        //            windowStart = Math.max(windowStart, charIndexMap.get(rightChar) + 1);
        //        }
        //        charIndexMap.put(rightChar, windowEnd); // insert the 'rightChar' into the map
        //        maxLength = Math.max(maxLength, windowEnd - windowStart + 1); // remember the maximum length so far
        //    }

        //    return maxLength;
        //}
    }
}

/*
 * The algorithm’s space complexity will be 
�
(
�
)
O(K)
, where 
�
K
 is the number of distinct characters in the input string. This also means 
�
<
=
�
K<=N
, because in the worst case, the whole string might not have any duplicate character, so the entire string will be added to the HashMap. Having said that, since we can expect a fixed set of characters in the input string (e.g., 26 for English letters), we can say that the algorithm runs in fixed space 
�
(
1
)
O(1)
; in this case, we can use a fixed-size array instead of the HashMap.
 */