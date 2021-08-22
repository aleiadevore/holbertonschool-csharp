using System;

class Program
{
    static void Main()
    {
        double[,] m1 = new double[,] { {14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double[,] m2 = new double[,] {{6, 16, 21}, {5, 2, 0}, {1, 3, 7}};
        double[,] ans = MatrixMath.Add(m1, m2);
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