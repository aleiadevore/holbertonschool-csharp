using System;

class MatrixMath
{
    ///<summary>Rotates matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);

        if (height != 2 || width != 2)
            return new double[,] {{-1}};

        double[,] deg = new double[2, 2];
        //double[,] deg = new double[2, 2];

        deg[0, 0] = Math.Cos(angle);
        deg[1, 1] = Math.Cos(angle);
        deg[1, 0] = Math.Sin(angle) * -1;
        deg[0, 1] = Math.Sin(angle);

        for (int i = 0; i < deg.GetLength(0); i++)
        {
            for (int j = 0; j < deg.GetLength(1); j++)
            {
                Console.Write(deg[i, j]);
                if (j != deg.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        return Multiply(matrix, deg);
    }

    ///<summary>Multiplies two matrices</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int height = matrix1.GetLength(0);
        int width = matrix1.GetLength(1);

        int m2h = matrix2.GetLength(0);
        int m2w = matrix2.GetLength(1);

        // make array of row in matrix1
        // make array of column in matrix2
        // send to DotProduct

        // creating empty array for matrix1 rows
        double[] a1 = new double[width];
        // creating empty array for matrix2 columns
        double[] a2 = new double[m2h];

        // creating degwer array
        double[,] deg = new double[height, m2w];

        for (int i = 0; i < height; i++)
            {
                //filling in a1
                for (int j = 0; j < width; j++)
                    a1[j] = matrix1[i, j];
                for (int j = 0; j < m2w; j++)
                {
                    // filling in a2
                    for (int k = 0; k < m2h; k++)
                        a2[k] = matrix2[k, j];
                    try
                    {
                        double n = DotProduct(a1, a2);
                        deg[i, j] = n;
                    }
                    catch(InvalidOperationException)
                    {
                        return new double[,] {{-1}};
                    }
                }
            }
        return deg;
    }

    ///<summary>Returns dot product of two vectors</summary>///
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            throw new InvalidOperationException("Wrong length");

        double ans = 0;

        for (int i = 0; i < vector1.Length; i++)
            ans += vector1[i] * vector2[i];

        double after = Math.Round(ans, 2);
        if (ans > 0 && ans > after)
            after += 0.01;
        if (ans < 0 && ans < after)
            after -= 0.01;
        return after;
    }
}
