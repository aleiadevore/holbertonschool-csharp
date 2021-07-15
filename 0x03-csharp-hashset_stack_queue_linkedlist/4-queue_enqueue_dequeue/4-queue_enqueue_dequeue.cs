using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
    Boolean check = aQueue.Contains(search);

        // Number of elements in stack
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        // Prints top of stack
        if (aQueue.Count > 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Stack is empty");
        
        // Prints if contains search item search
        Console.WriteLine("Stack contains \"{0}\": {1}", search, check);

        // If aQueue contains the given item search, remove all items up to and including search;
        // otherwise, leave aQueue as is
        string[] aCopy = new string[aQueue.Count];
        aQueue.CopyTo(aCopy, 0);

        if (check == true)
        {
            foreach (string item in aCopy)
            {
                aQueue.Dequeue();
                if (item == search)
                    break;
            }
        }

        // Add a new given item newItem to aQueue
        if (newItem != null)
            aQueue.Enqueue(newItem);
        
        return aQueue;

    }
}
