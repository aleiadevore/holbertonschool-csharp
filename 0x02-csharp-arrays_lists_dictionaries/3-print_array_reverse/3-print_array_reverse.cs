using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine();
                return;
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                    Console.Write("{0} ", array[i]);
                else
                    Console.WriteLine(array[i]);
            }
        }
    }
