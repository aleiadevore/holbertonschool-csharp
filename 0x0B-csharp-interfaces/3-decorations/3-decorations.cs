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
    public Door(string Name="Door")
    {
        name = Name;
    }

    ///<summary>Interacts with door</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

///<summary>Interacts with decoration</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>Gets and sets isQuestItem</summary>
    public bool isQuestItem { get; set; }
    ///<summary>Gets and sets durability</summary>
    public int durability { get; set; }

    ///<summary>Decoration constructor</summary>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability < 1)
            throw new ArgumentException("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary>Interacts with decoration</summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    ///<summary>Breaks decoration</summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}


/*public class Key : Base, ICollectable
{
    ///<summary>Key constructor</summary>
    public Door(string name="Key", bool isCollected=false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
} */

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
