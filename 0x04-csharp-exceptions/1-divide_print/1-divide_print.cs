using System;

class Int
{
    public static void divide(int a, int b)
    {
        int ans = 0;

        try
        {
            ans = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, ans);
        }
    }
}
