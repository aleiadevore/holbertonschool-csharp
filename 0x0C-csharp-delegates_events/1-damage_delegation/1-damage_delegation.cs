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
        this.hp -= damage;
    }

    ///<summary>Handles healing</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP");
        this.hp += heal;
    }

    ///<summary>Prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
