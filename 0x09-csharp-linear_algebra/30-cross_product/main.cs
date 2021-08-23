using System;

class Program
{
    static void Main()
    {
        double[] v1 = new double[] { 2, -2, 1 };
        double[] v2 = new double[] { -8, 8, -4 };
        double[] ans = MatrixMath.CrossProduct(v1, v2);
        Console.Write("( ");
        for (int i = 0; i < 3; i++)
        {
            if (i < 2)
                Console.Write("{0}, ",ans[i]);
            else
                Console.Write("{0} ",ans[i]);
        }
        Console.WriteLine(")\n");

        double[] v3 = new double[] { 2, 3, 4 };
        double[] v4 = new double[] { 5, 6, 7 };
        double[] ans2 = MatrixMath.CrossProduct(v3, v4);
        Console.Write("(");
        for (int i = 0; i < 3; i++)
        {
            if (i < 2)
                Console.Write("{0}, ",ans2[i]);
            else
                Console.Write("{0} ",ans2[i]);
        }
        Console.WriteLine(")\n");
    }
}
