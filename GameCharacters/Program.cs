using GameCharacters.Models;

namespace GameCharacters;

public class Program
{
    public static void Main(string[] args)
    {
        Character warrior = new Warrior("Warrior");
        Character archer = new Archer("Archer");
        Character mage = new Mage("Mage");

        warrior.Attack();
        archer.Attack();
        mage.Attack();
    }
}