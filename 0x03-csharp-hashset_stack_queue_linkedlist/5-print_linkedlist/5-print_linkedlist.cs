using System;
using System.Collections.Generic;
using System.Collections;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> nList = new LinkedList<int>();

        if (size < 0)
            return nList;
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(i);
            nList.AddLast(i);
        }
        return nList;
        
    }
}
