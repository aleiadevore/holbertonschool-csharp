using System;
using System.Reflection;

class Obj
{
    /// <summary>prints the names of the available properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        var t = myObj.GetType();
        var i = t.GetTypeInfo();
        Console.WriteLine("{0} Properties:", i.Name);

        // cycles through properites(in list) and prints each
       foreach (var property in t.GetProperties())
            Console.WriteLine(property.Name);
        
        Console.WriteLine("{0} Methods:", i.Name);

        // cycles through methods(in list) and prints each
       foreach (var method in t.GetMethods())
            Console.WriteLine(method.Name);

    }
}
