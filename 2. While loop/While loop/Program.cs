using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;

            while (x < 10)
            {
                Console.WriteLine("x is equal: " + x);
                x++;
                if (x == 10)
                {
                    Console.WriteLine("While loop is closing, x is " + x);
                }
            }
            
        }
    }
}
