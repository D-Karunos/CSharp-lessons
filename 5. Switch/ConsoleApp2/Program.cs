using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            
            switch (x)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
            }

        }
    }
}
