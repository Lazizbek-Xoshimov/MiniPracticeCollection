namespace GameCharacters.Models;

public class Warrior : Character
{
    public Warrior(string name) : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with sword.");
    }
}