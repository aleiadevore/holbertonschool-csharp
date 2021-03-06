using System;

class MatrixMath
{
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

        // creating answer array
        double[,] ans = new double[height, m2w];

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
                        ans[i, j] = n;
                    }
                    catch(InvalidOperationException)
                    {
                        return new double[,] {{-1}};
                    }
                }
            }
        return ans;
    }

    ///<summary>Returns dot product of two vectors</summary>///
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            throw new InvalidOperationException("Wrong length");

        double ans = 0;

        for (int i = 0; i < vector1.Length; i++)
            ans += vector1[i] * vector2[i];

        return ans;
    }
}
