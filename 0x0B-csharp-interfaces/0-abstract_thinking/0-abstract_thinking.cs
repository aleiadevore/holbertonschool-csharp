using System;

///<summary>Creates generic abstract class</summary>
public abstract class Base
{
    ///<summary>Name</summary>
    public string name { get; set; }

    ///<summary>Overrides ToString method</summary>
    public override string ToString()
    {
    
        return this.name + " is a " + this.GetType();
    }
}
