using System;

class Program
{
    static void Main()
    {
        double[] vector0 = new double[] {64, 121};
        double x = VectorMath.Magnitude(vector0);
        Console.WriteLine("Should be: 136.88");
        Console.WriteLine("Is: {0}\n", x);

        double[] vector1 = new double[] {3, 9};
        x = VectorMath.Magnitude(vector1);
        Console.WriteLine("Should be: 9.49");
        Console.WriteLine("Is: {0}\n", x);

        double[] vector2 = new double[] {7, -3, -9};
        x = VectorMath.Magnitude(vector2);
        Console.WriteLine("Should be: 11.79");
        Console.WriteLine("Is: {0}\n", x);

        double[] vector3 = new double[] {};
        x = VectorMath.Magnitude(vector3);
        Console.WriteLine("Should be: -1");
        Console.WriteLine("Is: {0}\n", x);

        double[] vector4 = new double[] {1};
        x = VectorMath.Magnitude(vector4);
        Console.WriteLine("Should be: -1");
        Console.WriteLine("Is: {0}\n", x);

        double[] vector5 = new double[] {1, 2, 3, 4};
        x = VectorMath.Magnitude(vector5);
        Console.WriteLine("Should be: -1");
        Console.WriteLine("Is: {0}\n", x);
    }
}