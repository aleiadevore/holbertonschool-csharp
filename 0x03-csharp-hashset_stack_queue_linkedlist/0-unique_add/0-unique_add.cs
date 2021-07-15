using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        var uni = myList.Distinct();

        int i = 0;

        foreach (int n in uni)
        {
            i += n;
        }

        return i;
    }
}
