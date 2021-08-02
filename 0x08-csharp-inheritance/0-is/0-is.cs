using System;

class Obj
{
    /// <summary>Returns True is object is int, otherwise returns False</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType().Equals(typeof(int)))
            return true;
        return false;
    }
}
