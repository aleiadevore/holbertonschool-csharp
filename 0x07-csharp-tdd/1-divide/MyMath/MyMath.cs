using System;

namespace MyMath
{
    ///<summary>Creates class of operations</summary>
    public class Operations
    {
        ///<summary>Divides all elements of a matrix</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] newMatrix = new int[,];

            if (matrix == null)
                return null;
            foreach (int i in matrix)
            {
                try
                {
                    newMatrix.Add(i / number);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }
            }
            
        }
    }
}
