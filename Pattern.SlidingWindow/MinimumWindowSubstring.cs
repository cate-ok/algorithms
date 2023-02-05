﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.SlidingWindow
{
    /*
    Given a string and a pattern, find the smallest substring in the given string which has all the character occurrences of the given pattern.
 */
    class MinimumWindowSubstring
    {
        // O(N+M)
        //The space complexity of the algorithm is O(M) since in the worst case, the whole pattern can have distinct characters which will go into the HashMap.In the worst case, we also need O(N)  space for the resulting substring, which will happen when the input string is a permutation of the pattern.
        public static string FindSubstring(string str, string pattern)
        {
            // TODO: Write your code here
            return "";
        }
    }
}
/*
public static String findSubstring(String str, String pattern) {
    int windowStart = 0, matched = 0, minLength = str.length() + 1, subStrStart = 0;
    Map<Character, Integer> charFrequencyMap = new HashMap<>();
    for (char chr : pattern.toCharArray())
      charFrequencyMap.put(chr, charFrequencyMap.getOrDefault(chr, 0) + 1);

    // try to extend the range [windowStart, windowEnd]
    for (int windowEnd = 0; windowEnd < str.length(); windowEnd++) {
      char rightChar = str.charAt(windowEnd);
      if (charFrequencyMap.containsKey(rightChar)) {
        charFrequencyMap.put(rightChar, charFrequencyMap.get(rightChar) - 1);
        if (charFrequencyMap.get(rightChar) >= 0) // count every matching of a character
          matched++;
      }

      // shrink the window if we can, finish as soon as we remove a matched character
      while (matched == pattern.length()) {
        if (minLength > windowEnd - windowStart + 1) {
          minLength = windowEnd - windowStart + 1;
          subStrStart = windowStart;
        }

        char leftChar = str.charAt(windowStart++);
        if (charFrequencyMap.containsKey(leftChar)) {
          // note that we could have redundant matching characters, therefore we'll decrement the
          // matched count only when a useful occurrence of a matched character is going out of the window
          if (charFrequencyMap.get(leftChar) == 0)
            matched--;
          charFrequencyMap.put(leftChar, charFrequencyMap.get(leftChar) + 1);
        }
      }
    }

    return minLength > str.length() ? "" : str.substring(subStrStart, subStrStart + minLength);
  }
 */
