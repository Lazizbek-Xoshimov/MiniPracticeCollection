namespace NotificationSystem.Models;

public class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sms notification sent.");
    }
}