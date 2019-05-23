using System;

namespace lessons.Payments
{
    public class PayPal
    {
        public static void Pay(int amount)
        {
            // Console.WriteLine("Pad " + amount + 'Successfully with PayPal");
            //Console.WriteLine("Pay {0} Successfully with PayPal, amount");

            Console.WriteLine($"Pay ${amount} Successfully with PayPal ");

        }
    }
}