using System;

class Program
{
    static void Main()
    {
        /*double[,] m1 = new double[,] { {1, 2}, {3, 4}};
        double[,] ans = MatrixMath.Rotate2D(m1, 2);
        for (int i = 0; i < ans.GetLength(0); i++)
        {
            for (int j = 0; j < ans.GetLength(1); j++)
            {
                Console.Write(ans[i, j]);
                if (j != ans.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }*/

        Console.WriteLine();
        double[,] m3 = new double[,] { {1, 2}, {3, 4}};
        double[,] ans2 = MatrixMath.Transpose(m3);
        for (int i = 0; i < m3.GetLength(0); i++)
        {
            for (int j = 0; j < m3.GetLength(1); j++)
            {
                Console.Write(m3[i, j]);
                if (j != m3.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ans2.GetLength(0); i++)
        {
            for (int j = 0; j < ans2.GetLength(1); j++)
            {
                Console.Write(ans2[i, j]);
                if (j != ans2.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
