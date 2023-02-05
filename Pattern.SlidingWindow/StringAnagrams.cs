using System;
using System.Collections.Generic;

namespace Pattern.SlidingWindow
{
    /*
    Given a string and a pattern, find all anagrams of the pattern in the given string.

Every anagram is a permutation of a string. As we know, when we are not allowed to repeat characters while finding permutations of a string, we get 
�
!
N!
 permutations (or anagrams) of a string having 
�
N
 characters. For example, here are the six anagrams of the string “abc”:

abc
acb
bac
bca
cab
cba
Write a function to return a list of starting indices of the anagrams of the pattern in the given string.
 */
    class StringAnagrams
    {
        //// Time O(N+M) N and M - num of characters in str and the pattern

        // The space complexity of the algorithm is O(M) since in the worst case, the whole pattern can have distinct characters which will go into the HashMap.In the worst case, we also need O(N) space for the result list, this will happen when the pattern has only one character and the string contains only that character.
        public static List<int> FindStringAnagrams(string str, string pattern)
        {
            List<int> resultIndices = new List<int>();
            // TODO: Write your code here
            return resultIndices;
        }
    }
}

/*
public static List<Integer> findStringAnagrams(String str, String pattern) {
    int windowStart = 0, matched = 0;
    Map<Character, Integer> charFrequencyMap = new HashMap<>();
    for (char chr : pattern.toCharArray())
      charFrequencyMap.put(chr, charFrequencyMap.getOrDefault(chr, 0) + 1);

    List<Integer> resultIndices = new ArrayList<Integer>();
    // our goal is to match all the characters from the map with the current window
    for (int windowEnd = 0; windowEnd < str.length(); windowEnd++) {
      char rightChar = str.charAt(windowEnd);
      // decrement the frequency of the matched character
      if (charFrequencyMap.containsKey(rightChar)) {
        charFrequencyMap.put(rightChar, charFrequencyMap.get(rightChar) - 1);
        if (charFrequencyMap.get(rightChar) == 0)
          matched++;
      }

      if (matched == charFrequencyMap.size()) // have we found an anagram?
        resultIndices.add(windowStart);

      if (windowEnd >= pattern.length() - 1) { // shrink the window
        char leftChar = str.charAt(windowStart++);
        if (charFrequencyMap.containsKey(leftChar)) {
          if (charFrequencyMap.get(leftChar) == 0)
            matched--; // before putting the character back, decrement the matched count
          // put the character back
          charFrequencyMap.put(leftChar, charFrequencyMap.get(leftChar) + 1);
        }
      }
    }

    return resultIndices;
  }
 */
