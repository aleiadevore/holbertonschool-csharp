using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Text
{
    public class Str
    {
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
