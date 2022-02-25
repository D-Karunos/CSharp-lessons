using System;

namespace break_statement
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
                    if ( i == 11)
                {
                    Console.WriteLine("'break' can BREAK anything!");
                    break;
                }
                }
            }
        }
    }