using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // using for to print every char of the string
            for (int i = 0; i < 17; i++)
            {
                string word = "I come with peace";
                Console.WriteLine(word[i]);
            }
        }
    }
}
