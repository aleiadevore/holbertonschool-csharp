using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Boolean check = aStack.Contains(search);

        // Number of elements in stack
        Console.WriteLine("Number of items: {0}", aStack.Count);

        // Prints top of stack
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        
        // Prints if contains search item search
        Console.WriteLine("Stack contains \"{0}\": {1}", search, check);

        // If aStack contains the given item search, remove all items up to and including search;
        // otherwise, leave aStack as is
        string[] aCopy = new string[aStack.Count];
        aStack.CopyTo(aCopy, 0);

        if (check == true)
        {
            foreach (string item in aCopy)
            {
                aStack.Pop();
                if (item == search)
                    break;
            }
        }

        // Add a new given item newItem to aStack
        if (newItem != null)
            aStack.Push(newItem);
        
        return aStack;

    }
}
