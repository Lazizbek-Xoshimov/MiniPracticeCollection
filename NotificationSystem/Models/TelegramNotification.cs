namespace NotificationSystem.Models;

public class TelegramNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Telegram notification sent.");
    }
}