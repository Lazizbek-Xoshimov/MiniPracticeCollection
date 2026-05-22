namespace SmartDevices.Models;

public class Phone : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Phone is turning on.");
    }
}