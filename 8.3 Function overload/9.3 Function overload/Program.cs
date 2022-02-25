using System;

namespace _9._3_Function_overload
{
    class Program
    {
        //Functions with same names but with different parameters can exist and will be called only when parameters match
        static void Function(int x)
        {
            Console.WriteLine("First Function: " + x);
        }

        static void Function(double x)
        {
            Console.WriteLine("Second Function: " + x);
        }

        static void Function(string l, int x)
        {
            Console.WriteLine("Third Function: "+l + x);
        }

        static void Main(string[] args)
        {
            Function(1996);
            Function(02.05);
            Function("My age is: ", 25);
            
        }
    }
}
