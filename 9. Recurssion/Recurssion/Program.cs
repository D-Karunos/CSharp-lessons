using System;

namespace Recurssion
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Main(string[] args)
        {
            //calculating factorial of any given variable
            Console.WriteLine( Factorial(5) );
        }
    }
}
