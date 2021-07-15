using System;
using System.Collections.Generic;
using System.Collections;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int i = 0;
        
        foreach (int item in myLList)
            i++;

        return i;
        
    }
}