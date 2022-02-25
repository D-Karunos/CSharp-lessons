using System;

namespace _10._Class
{
    class Program
    {
        class bank
        {
            private double Balance = 0;

            public void Withraw(double x)
            {
                if ((Balance - x)< 0)
                {
                    Console.WriteLine("Insuficent balance");
                }
                else
                {
                    Balance -= x;
                }
            }

            public void Deposit(double x)
            {
                Balance += x;
            }

            public void Check_Balance()
            {
                Console.WriteLine(Balance);
            }

        }

        static void Main(string[] args)
        {

            bank a = new bank();
            bank b = new bank();

            a.Withraw(10);
            a.Deposit(50);

            b.Deposit(5.53);
            b.Withraw(3.30);

            a.Check_Balance();
            b.Check_Balance();






        }
    }
}
