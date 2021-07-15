using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n >= myLList.Count || myLList.Count == 0 || myLList == null || n < 0)
            return 0;
        return myLList.ElementAt(n);
    }
}
