using System;

///<summary>Creates generic queue</summary>
public class Queue<T>
{
    Node head = null;
    Node tail = null;
    int count = 0;

    ///<summary>Creates method to check type of Queue</summary>
    public System.Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>Creates a new node for a Queue of type T</summary>
    public class Node
    {
        ///<summary>Value to put into node</summary>
        public T value;
        ///<summary>Next element in queue</summary>
        public Node next;

        ///<summary>Constructor, takes value for new node and sets it</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    ///<summary>Adds node to the end of queue</summary>
    public Node Enqueue(T value)
    {
        Node newNode;

        if (head == null)
        {
            newNode = new Node(value);
            head = newNode;
            head.next = null;
            tail = head;
        }
        else
        {
            newNode = new Node(value);
            newNode.next = null;
            tail.next = newNode;
            tail = newNode;
        }
        count++;
        return newNode;
    }

    ///<summary>Returns number of nodes</summary>
    public int Count()
    {
        return count;
    }

    ///<summary>Removes first node in queue and returns its value</summary>
    public T Dequeue()
    {
        T value;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        value = head.value;
        head = head.next;
        count--;
        return value;
    }
}
