using System;

class MatrixMath
{
    ///<summary>Multiplies a matrix by a scalar</summary>///
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int Height = matrix.GetLength(0);
        int Width = matrix.GetLength(1);

        if (Height < 2 || Height > 3)
            return new double[,] {{-1}};

        double[,] ans = new double[Height, Width];

        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
                ans[i, j] = matrix[i, j] * scalar;
        }

        return ans;
    }
}
