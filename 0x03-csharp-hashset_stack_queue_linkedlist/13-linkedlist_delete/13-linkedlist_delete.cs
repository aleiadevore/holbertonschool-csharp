using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> current;

        if (myLList == null || myLList.Count == 0)
            return;
        if (index == 0)
            myLList.RemoveFirst();
        else if (index == myLList.Count -1)
            myLList.RemoveLast();
        else
        {
            for (current = myLList.First; current != null; current = current.Next)
            {
                if (i == index)
                {
                    myLList.Remove(current);
                    break;
                }
                i++;
            }
        }
    }
}
