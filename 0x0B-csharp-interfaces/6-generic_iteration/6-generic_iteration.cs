using System;
using System.Collections;
using System.Collections.Generic;

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

///<summary>Creates key</summary>
public class Key : Base, ICollectable
{
    ///<summary>Gets and sets isCollected</summary>
    public bool isCollected { get; set; }
    ///<summary>Key constructor</summary>
    public Key(string name="Key", bool isCollected=false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary>Determines if key is collected</summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
            Console.WriteLine($"You have already picked up the {name}.");
    }
}

///<summary>Handles objects in the room</summary>
public class Objs<T> : IEnumerable<T>
{
    ///<summary>Gets and sets items</summary>
    public List<T> Items { get; private set; }

    ///<summary>Items constructor</summary>
    public Objs() { Items = new List<T>(); }

    ///<summary>Adds item to list</summary>
    public void Add(T item)
    {
        Items.Add(item);
    }

    ///<summary>Gets Enumerator for object list</summary>
    public IEnumerator<T> GetEnumerator()
    {
        return Items.GetEnumerator();
    }

    ///<summary>Returns IEnumerator for object list</summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

}
