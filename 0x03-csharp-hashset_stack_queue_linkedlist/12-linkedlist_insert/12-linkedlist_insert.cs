using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current;
        LinkedListNode<int> nnode;

        for (current = myLList.First; current != null; current = current.Next)
        {
            if (current.Value > n)
            {
                myLList.AddBefore(current, n);
                return current.Previous;
            }
            else if (current.Next != null)
            {
                if (current.Next.Value > n && current.Value > n)
                {
                    nnode = myLList.AddAfter(current, n);
                    return current.Previous;
                }
            }
            else if (current.Value < n)
            {
                nnode = myLList.AddAfter(current, n);
                return current.Next;
            }
        }
        return null;
    }
}
