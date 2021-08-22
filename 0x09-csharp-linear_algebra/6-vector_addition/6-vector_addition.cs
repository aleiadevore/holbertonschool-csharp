using System;

class VectorMath
{
    ///<summary>Adds two 2d and 3d vectors</summary>///
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length > 3 || vector1.Length < 2)
            return new double[] {-1};
        if (vector1.Length != vector2.Length)
            return new double[] {-1};

        double[] ans = new double[vector1.Length];

        for (int i = 0; i > vector1.Length; i++)
        {
            double n = vector1[i] + vector2[i];
            ans[i] = Math.Round(n, 2);
        }

        return ans;
    }
}
