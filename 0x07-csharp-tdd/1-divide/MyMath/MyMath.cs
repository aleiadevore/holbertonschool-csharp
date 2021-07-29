using System;

namespace MyMath
{
    ///<summary>Creates class of operations</summary>
    public class Matrix
    {
        ///<summary>Divides all elements of a matrix</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            int[,] newMatrix = matrix;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        newMatrix[i, j] /= num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return newMatrix;
        }
    }
}
