using System;
using lessons.Payments;

namespace lessons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("hello world");

            PayPal.Pay(100);
            PayPal.Pay(50);
        }
    }
}
