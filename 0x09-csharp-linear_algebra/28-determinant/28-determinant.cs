using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);

        if (height < 2 || height > 3 || width < 0 || width > 3)
            return -1;
        
        if (height != width)
            return -1;

        if (height == 2)
            return Det2D(matrix);
        return Det3D(matrix);
    }

    ///<summary>Helper function for 2D determinates</summary>
    public static double Det2D(double[,] m)
    {
        return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
    }

    ///<summary>Helper function for 3D determinates</summary>
    public static double Det3D(double[,] m)
    {
        double sub1 = m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1];
        double sub2 = m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0];
        double sub3 = m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0];

        return m[0,0] * sub1 - m[0,1] * sub2 + m[0,2] * sub3;
    }
}
