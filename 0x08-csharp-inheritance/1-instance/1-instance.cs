using System;

class Obj
{
    ///<summary>Returns true if obj is instance of or inherits from instance of Array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}
