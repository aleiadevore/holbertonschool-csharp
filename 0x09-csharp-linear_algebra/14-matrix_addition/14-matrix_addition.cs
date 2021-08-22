using System;

class MatrixMath
{
    ///<summary>Returns dot product of two vectors</summary>///
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int m1Width = matrix1.GetLength(1);
        int m1Height = matrix1.GetLength(0);

        int m2Width = matrix2.GetLength(1);
        int m2Height = matrix2.GetLength(0);

        if (m1Width != m2Width || m1Height != m2Height)
            return new double[,] {{-1}};
        if (m1Height < 2 || m1Height > 3)
            return new double[,] {{-1}};


        double[,] ans = new double[m1Height, m1Width];

        for (int i = 0; i < m1Height; i++)
            {
                for (int j = 0; j < m1Width; j++)
                    ans[i,j] = matrix1[i, j] + matrix2[i, j];
            }

        return ans;
    }
}
