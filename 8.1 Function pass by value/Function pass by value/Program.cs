using System;

namespace Function_pass_by_value
{
    class Program
    {
        static void sq(int num)
        {
            num = num * num;
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int x = 6;
            Console.Write(x + " squared is: ");
            sq(x);

        }
    }
}
