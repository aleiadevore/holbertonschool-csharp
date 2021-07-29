using System;

namespace Text
{
    ///<summary>Checks elements of string</summary>
    public class Str
    {
        ///<summary>Checks if string is palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == "")
                return true;
            
            // Remove spaces
            s.Replace(" ", "");

            // Convert to array in order to reverse
            char[] forward = s.ToCharArray();
            char[] backward = forward;
            
            Array.Reverse(forward);

            return forward.Equals(backward);
        }
    }
}
