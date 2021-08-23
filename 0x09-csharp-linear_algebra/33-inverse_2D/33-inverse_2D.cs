using System;

class MatrixMath
{
    ///<summary>Calculates inverse of 2D matrix</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};

        double denom = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        if (denom == 0)
            return new double[,] {{-1}};

        double scalar = 1 / denom;

        double[,] temp = new double[,] { {matrix[1,1], matrix[0, 1] * -1},
        {matrix[1, 0] * -1, matrix[0, 0]} };

        return MultiplyScalar(temp, scalar);
    }

    ///<summary>Multiplies a matrix by a scalar</summary>///
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int Height = matrix.GetLength(0);
        int Width = matrix.GetLength(1);

        if (Height < 2 || Height > 3)
            return new double[,] {{-1}};
        if (Width < 2 || Width > 3)
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
