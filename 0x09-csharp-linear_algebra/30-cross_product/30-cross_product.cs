using System;

class VectorMath
{
    ///<summary>Returns cross product of two 3D vectors</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};
        
        double x = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        double y = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        double z = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        double[] ans = new double[3];

        ans[0] = Math.Round(x, 2);
        ans[1] = Math.Round(y, 2);
        ans[2] = Math.Round(z, 2);

        return ans;
    }
}
