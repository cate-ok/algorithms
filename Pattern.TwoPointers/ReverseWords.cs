using System.Text;
using System.Text.RegularExpressions;

namespace Pattern.TwoPointers
{
    /*
     Given a sentence, reverse the order of its words without affecting the order of letters within a given word. The returned string should only have a single space separating each word. Do not include any extra spaces.
    The length of the sentence should be equal to or more than one character or word.
     Sentence contains English uppercase and lowercase letters, digits, and spaces.
     */
    public class ReverseWords
    {
        /*
         Because the array is traversed twice, the time complexity of this solution is O(n+n)=O(n)
        Space O(n)
         */
        public static string Reverse(string s)
        {
            //char[] cArray = s.ToCharArray();
            //Array.Reverse(cArray);

            s = TrimSpaces(s);
            StringBuilder sb = new StringBuilder(s);
            ReverseString(sb, 0, sb.Length - 1);

            int strLength = sb.Length;
            int start = 0, end = 0;
            while (start < strLength)
            {
                while (end < strLength && sb[end] != ' ')
                    end++;

                // Reverse word
                ReverseString(sb, start, end - 1);

                // Move to the next word
                start = end + 1;
                end = start;
            }
            return sb.ToString();
        }

        static string TrimSpaces(string s)
        {
            Regex trimmer = new Regex(@"\s\s+");
            return trimmer.Replace(s, " ");
        }



        static void ReverseString(StringBuilder sb, int startRev, int endRev)
        {
            while (startRev < endRev)
            {
                var ch = sb[startRev];
                sb[startRev] = sb[endRev];
                sb[endRev] = ch;
                startRev++;
                endRev--;
            }
        }
    }
}

/*
 // trim leading, trailing and multiple spaces
    static string TrimSpaces(char[] a, int n)
    {
        int x = 0, y = 0;

        while (y < n)
        {
            while (y < n && a[y] == ' ') y++;             // skip spaces
            while (y < n && a[y] != ' ') a[x++] = a[y++]; // keep non spaces
            while (y < n && a[y] == ' ') y++;             // skip spaces
            if (y < n) a[x++] = ' ';                      // keep only one space
        }

        return new String(a).Substring(0, x);
    }
 */