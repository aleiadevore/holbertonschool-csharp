using System;

class Program
{
    static void Main()
    {
        double[,] m2 = new double[,] { {-4, 9, 0}, {1, -2, 1}, {3, -4, 2}};
        double ans = MatrixMath.Determinant(m2);
        for (int i = 0; i < m2.GetLength(0); i++)
        {
            for (int j = 0; j < m2.GetLength(1); j++)
            {
                Console.Write(m2[i, j]);
                if (j != m2.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Determinate: {0}\n", ans);

        double[,] m3 = new double[,] { {2, 2}, {-9, 4}};
        double ans2 = MatrixMath.Determinant(m3);
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
        Console.WriteLine("Determinate: {0}", ans2);
    }
}
