using System;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            do
            {
                Console.WriteLine(x);
                x--;
            } while (x != 0);
            Console.WriteLine("Times up!");
        }
    }
}
