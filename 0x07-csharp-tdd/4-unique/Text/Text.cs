using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Text
{
    ///<summary>Creates String tools</summary>
    public class Str
    {
        ///<summary>Chacks for first instance of unique character in string</summary>
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c] += 1;
                else
                    charCount.Add(c, 1);
            }

            int i = 0;
            foreach (char c in s)
            {
                if (charCount[c] == 1)
                    return i;
                i++;
            }
            return -1;
        }
    }
}
