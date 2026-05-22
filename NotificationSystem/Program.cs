using NotificationSystem.Models;

namespace NotificationSystem;

public class Program
{
    public static void Main(string[] args)
    {
        EmailNotification emailNotification = new EmailNotification();
        SmsNotification smsNotification = new SmsNotification();
        TelegramNotification telegramNotification = new TelegramNotification();

        emailNotification.Send();
        smsNotification.Send();
        telegramNotification.Send();
    }
}