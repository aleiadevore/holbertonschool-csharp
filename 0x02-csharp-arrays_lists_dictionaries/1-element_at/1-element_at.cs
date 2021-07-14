using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index > array.Length - 1 || index < 0)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        Console.WriteLine("{0}: {1}", index, array.Length - 1);
        return array[index];
    }
}
