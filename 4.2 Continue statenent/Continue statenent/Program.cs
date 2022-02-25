using System;

namespace Continue_statenent
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "ABCDEFGHIJKMNLOPQRSTUVWXYZ";

            Random rnd = new Random();
            int my_ranodm = rnd.Next(27); // random number between 0 and 26


            for (int i = 0; i < 26; i++){

                if (i == my_ranodm)
                {
                    continue; // should skip one letter of the alphabet
                }

            
                Console.Write(abc[i]);
            }

            Console.WriteLine(); // making space
            Console.Write("Find missing letter");

        }
    }
}
