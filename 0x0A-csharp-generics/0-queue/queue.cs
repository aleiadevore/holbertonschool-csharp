using System;

///<summary>Creates generic queue</summary>
public class Queue<T>
{
    ///<summary>Creates method to check type of Queue</summary>
    public System.Type CheckType()
    {
        return typeof(T);
    }
}
