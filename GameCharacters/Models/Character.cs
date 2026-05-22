namespace GameCharacters.Models;

public class Character
{
    public string Name { get; set; }

    public Character(string name)
    {
        Name = name;
    }

    public virtual void Attack()
    {
    }
}