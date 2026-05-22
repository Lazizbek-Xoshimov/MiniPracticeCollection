namespace NotificationSystem.Models;

public class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Email notification sent.");
    }
}