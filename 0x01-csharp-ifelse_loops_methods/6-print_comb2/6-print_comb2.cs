using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            for (x = 0; x <= 9; x++)
            {
                for (y = x + 1; y <= 9; y++)
                    if (x == 8 && y == 9)
                        Console.WriteLine("{0}{1}", x, y);
                    else
                        Console.Write("{0}{1}, ", x, y);
                        
            }
        }
    }
}
