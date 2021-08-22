using System;

class VectorMath
{
    ///<summary>Multiplies a vector by a scalar</summary>///
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length > 3 || vector.Length < 2)
            return new double[] {-1};

        double[] ans = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
            ans[i] = vector[i] * scalar;

        return ans;
    }
}
