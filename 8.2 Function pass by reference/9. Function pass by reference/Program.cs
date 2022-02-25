using System;

namespace Function_pass_by_value
{
    class Program
    {
        static void sq(ref int num)
        {
            num = num * num;
        }
        static void Main(string[] args)
        {
            int x = 6;

            Console.Write(x + " squared is: ");

            sq(ref x);

            Console.WriteLine(x); // X value is the same as num because x passed as a reference.

        }
    }
}
