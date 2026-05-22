using SmartDevices.Models;

namespace SmartDevices;

public class Program
{
    public static void Main(string[] args)
    {
        Device phone = new Phone();
        Device laptop = new Laptop();
        Device tv = new TV();

        phone.TurnOn();
        laptop.TurnOn();
        tv.TurnOn();
    }
}