using System;

class VectorMath
{
    ///<summary>Returns dot product of two vectors</summary>///
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length > 3 || vector1.Length < 2)
            return -1;
        if (vector1.Length != vector2.Length)
            return -1;

        double ans = 0;

        for (int i = 0; i < vector1.Length; i++)
            ans += vector1[i] * vector2[i];

        return ans;
    }
}