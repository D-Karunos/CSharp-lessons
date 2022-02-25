using System;

namespace Methods_and_Parametres
{
    class Program
    {

        static void method (int parameter1, int parameter2)
        {
            parameter1++; 
            Console.WriteLine(parameter1-parameter2); // printing two variable addition (5+1)-(-2)
        }

        static void Main(string[] args)
        {
            int x = 5, y =-2; 

            method(x,y); //sending my parameter to method
        }
    }
}
