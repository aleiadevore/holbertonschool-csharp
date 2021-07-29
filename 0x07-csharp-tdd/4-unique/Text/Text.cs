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
            /// use Disctinct to find unique instances
            List<char> sList = new List<char>();
            sList.AddRange(s);

            HashSet<char> sHash = new HashSet<char>(sList);

            /// find first instance of new str in old str
            int i = 0;
            foreach (char c in s)
            {
                if (c == sHash.First())
                    return i;
                i++;
            }
            return -1;
        }
    }
}
