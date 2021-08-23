using System;

class MatrixMath
{
    ///<summary>Transposes matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int width = matrix.GetLength(1);
        int height = matrix.GetLength(0);

        double[,] ans = new double[width, height];
        double[] row = new double[width];

        for (int i = 0; i < height; i++)
        {
            // Goes through each elem to set row
            for (int j = 0; j < width; j++)
            {
                row[j] = matrix[i, j];
            }
            // Goes through ans w/ column = height
            for (int j = 0; j < width; j++)
                ans[j, i] = row[j];
        }

        return ans;
    }
}
