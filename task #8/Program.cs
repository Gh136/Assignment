using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task__8
{
    public class Payment
    {
        public double Amount { get; set; }

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount}.");
        }

    }
    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount} for card number {CardNumber}.");
        }
    }
    public class CashPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing cash payment of {Amount}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment[] payments = new Payment[2];

            payments[0] = new CreditCardPayment
            {
                Amount = 100.50,
                CardNumber = "1234-5678-9012-3456"
            };
            payments[1] = new CashPayment
            {
                Amount = 50.00
            };
          

            for (int i = 0; i < payments.Length; i++)
            {
                payments[i].ProcessPayment();
            }
        }
    }
}
