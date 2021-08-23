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
    public static double Det3D(double[,] matrix)
    {
        return 0;
    }
}
