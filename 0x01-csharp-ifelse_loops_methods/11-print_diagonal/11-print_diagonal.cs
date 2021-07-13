using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
            return;
        }
        for (int i = 0; i < length; i++)
        {
            string line = new String(' ', i);
            Console.WriteLine("{0}\\", line);
        }
        Console.WriteLine();
    }
}
