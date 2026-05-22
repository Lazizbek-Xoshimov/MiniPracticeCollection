using PaymentSystem.Models;

namespace PaymentSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Payment clickPayment = new ClickPayment();
        Payment paymePayment = new PaymePayment();
        Payment cashPayment = new CashPayment();

        clickPayment.Pay();
        paymePayment.Pay();
        cashPayment.Pay();
    }
}