using System;

namespace Pattern.TwoPointers
{
    // Write a function that takes a string s as input and checks whether it’s a palindrome or not.
    // s ≤ 1≤ s.length ≤ 2 × 10^5
    // The string won’t have any spaces and will only consist of ASCII characters.
    public class ValidPalindrome
    {
        // Time O(N), Space O(1) - constant space
        public static bool IsPalindrome(string s)
        {
            int start = 0;
            int end = s.Length-1;

            while (start < end)
            {
                if (s[start]!= s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
