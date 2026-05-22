namespace PaymentSystem.Models;

public class CashPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with Cash");
    }
}