using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable 1
            int x = 20;

            //variable 2
            int y = 10;

            if (x > y)
            {
                Console.WriteLine("X is larger than Y");
            }
            else if (y > x)
            {
                Console.WriteLine("Y is larger that X");
            }

            else
            {
                Console.WriteLine("X is equal to Y");
            }
        }
    }
}
