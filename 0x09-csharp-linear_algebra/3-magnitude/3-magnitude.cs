using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double left = 0.00;

        if (vector.Length > 3 || vector.Length < 2)
            return (-1);

        foreach (double item in vector)
            left += item * item;
        double a = Math.Sqrt(left);
        return Math.Round(a, 2);
    }
}
