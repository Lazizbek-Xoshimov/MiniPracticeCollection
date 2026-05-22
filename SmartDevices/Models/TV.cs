namespace SmartDevices.Models;

public class TV : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("TV is turning on.");
    }
}