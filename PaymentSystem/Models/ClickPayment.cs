namespace PaymentSystem.Models;

public class ClickPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with Click.");
    }
}