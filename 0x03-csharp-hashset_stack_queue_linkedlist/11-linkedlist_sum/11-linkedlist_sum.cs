using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int i = 0;

        foreach (int n in myLList)
            i += n;
        return i;
    }
}
