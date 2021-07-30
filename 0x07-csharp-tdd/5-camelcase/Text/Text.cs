using System;

namespace Text
{
    ///<summary>Creates classes for strings</summary>
    public class Str
    {
        ///<summary>Determines number of words in camel case string</summary>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
                return 0;

            int i = 1;

            foreach (char c in s)
            {
                if (c >= 65 && c <= 90)
                    i += 1;
            }

            return i;

        }
    }
}
