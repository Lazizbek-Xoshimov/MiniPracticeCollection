namespace GameCharacters.Models;

public class Mage : Character
{
    public Mage(string name) : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} casts spell.");
    }
}