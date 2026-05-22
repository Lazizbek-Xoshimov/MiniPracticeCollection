namespace PaymentSystem.Models;

public class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("You have made the payment.");
    }
}