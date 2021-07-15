using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jA = new int [3][]
            {
                new int[] { 0, 1, 2, 3 }, 
                new int[] { 0, 1, 2, 3, 4, 5, 6} , 
                new int[] { 0, 1 }
            };
            //int[3][] bigArray = { { 0, 1, 2, 3 }, { 0, 1, 2, 3, 4, 5, 6} , { 0, 1 } };

            foreach (int[] elem in jA)
            {
                for (int i = 0; i < elem.Length; i++)
                {
                    if (i < elem.Length - 1)
                        Console.Write("{0} ", elem[i]);
                    else
                        Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
