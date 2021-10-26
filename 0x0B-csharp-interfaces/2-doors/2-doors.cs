using System;

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability {get; set;}
    void Break();
}

interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

///<summary>Creates generic abstract class</summary>
public abstract class Base
{
    ///<summary>Name</summary>
    public string name { get; set; }

    ///<summary>Overrides ToString method</summary>
    public override string ToString()
    {
    
        return name + " is a " + this.GetType();
    }
}

///<summary>Interacts with door</summary>
public class Door : Base, IInteractive
{
    ///<summary>Door constructor</summary>
    public Door( string Name)
    {
        name = Name;
    }

    ///<summary>Interacts with door</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

/*public class TestObject : Base, IBreakable, IInteractive, ICollectable
{
    ///<summary>Gets and sets durability</summary>
    public int durability { get; set; }
    ///<summary>Gets and sets isCollected</summary>
    public bool isCollected { get; set; }

    ///<summary>Implements Interact</summary>
    public void Interact()
    {
        // empty
    }

    ///<summary>Implements Break</summary>
    public void Break()
    {
        // empty
    }

    ///<summary>Implements Collect</summary>
    public void Collect()
    {
        // empty
    }
}*/
