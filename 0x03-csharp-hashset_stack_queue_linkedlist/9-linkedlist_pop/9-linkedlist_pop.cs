using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null)
            return 0;
        int i = myLList.First.Value;
        myLList.RemoveFirst();
        
        return i;
    }
}
