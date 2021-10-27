using System;

///<summary>Creates player</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Constructs Player</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    ///<summary>Delegate for health calculations</summary>
    public delegate float CalculateHealth(float fl);

    ///<summary>Handles damage</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        ValidateHP(hp -damage);
    }

    ///<summary>Handles healing</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    ///<summary>Validates and sets HP</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            newHp = 0;
        else if (newHp > this.maxHp)
            newHp = this.maxHp;
        this.hp = newHp;
    }

    ///<summary>Prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    ///<summary>Applies modifier to HP</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        // Playing with ways to access Modifier.
        // Can compare to enum.value or
        // Can cast as int and compare to index
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if ((int) modifier == 2)
            return baseValue * 1.5f;
        else
            return baseValue;
    }
}

///<summary>Defines modifiers</summary>
public enum Modifier {
    ///<summary>Weakest</summary>
    Weak,
    ///<summary>Middle</summary>
    Base,
    ///<summary>Good coffee</summary>
    Strong
}

///<summary>Modifier Calc delegation</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
