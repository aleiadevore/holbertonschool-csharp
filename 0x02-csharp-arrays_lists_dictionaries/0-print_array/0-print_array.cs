using System;
class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] a1 = new int[size];

        if (size == 0)
        {
            Console.WriteLine();
            return a1;
        }
        for (int i = 0; i < size; i++)
        {
            a1[i] = i;
            if (i != size - 1)
                Console.Write("{0} ", i);
            else
                Console.WriteLine(i);
        }
        
        return a1;
    }
}
