using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms.Algorithms.String
{
    public class StringAlgorithms
    {
        public bool IsPalindrome(string str, bool ignoreSpecialChars = true)
        {
            if (str.Length == 0)
                return true;

            var lowerStr = str.ToLower();
            if (ignoreSpecialChars)
            {
                lowerStr = Regex.Replace(lowerStr, @"\s+", "");
            }

            int lastIndex = lowerStr.Length - 1;
            for(var i = 0; i < (lowerStr.Length/2); i++)
            {
                if (lowerStr[i] != lowerStr[lastIndex - i])
                    return false;
            }
            return true;
        }

        public bool CheckPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            var ch1 = s1.ToArray();
            var ch2 = s2.ToArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            s1 = new string(ch1);
            s2 = new string(ch2);
            if (s1 == s2)
                return true;
            return false;
        }
    }
}
