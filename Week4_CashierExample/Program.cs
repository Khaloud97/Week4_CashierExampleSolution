﻿namespace Week4_CashierExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, To Khaloud shop!");
            
            Cashier ch1 = new Cashier(new Cash());
            Cashier ch2 = new Cashier(new MasterCard());
            Cashier ch3 = new Cashier(new VisaCard());
            Cashier ch4 = new Cashier(new Debit());
            ch1.CheckOut(120.35m);
            ch2.CheckOut(125.35m);
            ch3.CheckOut(105.35m);
            ch4.CheckOut(100.35m);
        }
    }
}