using System;

namespace MyMath
{
    ///<summary>Creates class of operations</summary>
    public class Operations
    {
        ///<summary>Divides all elements of a matrix</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] newMatrix = matrix;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (matrix == null)
                return null;
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
