using System;

namespace Text
{
    ///<summary>Checks elements of string</summary>
    public class Str
    {
        ///<summary>Checks if string is palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }
            
            // Remove spaces and punctuation
            s = s.Replace(" ", "");
            s = s.Replace(".", "");
            s = s.Replace("!", "");
            s = s.Replace(":", "");
            s = s.Replace(",", "");
            s = s.ToLower();

            // Convert to array in order to reverse
            char[] forward = s.ToCharArray();
            char[] backward = new char[forward.Length];

            for (int i = 0; i < forward.Length; i++)
            {
                backward[i] = forward[i];
            }
            
            Array.Reverse(backward);

            for (int i = 0; i < s.Length; i++)
            {
                if (forward[i] != backward[i])
                    return false;
            }
            return true;
        }
    }
}
