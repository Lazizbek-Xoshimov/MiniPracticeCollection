namespace NotificationSystem.Models;

public class Notification
{
    public virtual void Send()
    {
        Console.WriteLine("Notification sent.");
    }
}