using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double left = 0.00;

        foreach (double item in vector)
            left += item * item;
        double a = Math.Sqrt(left);
        return Math.Round(a, 2);
    }
}
