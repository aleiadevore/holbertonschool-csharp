using System;

class Program
{
    static void Main()
    {
        double[,] m1 = new double[,] { {2, 3}, {-1, 0}};
        double[,] m2 = new double[,] {{1, 7}, {-8, -2}};
        double[,] ans = MatrixMath.Multiply(m1, m2);
        for (int i = 0; i < ans.GetLength(0); i++)
        {
            for (int j = 0; j < ans.GetLength(1); j++)
            {
                Console.Write(ans[i, j]);
                if (j != ans.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}