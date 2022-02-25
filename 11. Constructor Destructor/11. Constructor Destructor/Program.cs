using System;

namespace _11._Constructor_Destructor
{
    class Program
    {

        class pet
        {
            private string name = "Fluffy";

            public pet()
            {
                Console.WriteLine(this.name);
            }
        }
        static void Main(string[] args)
        {
            pet a = new pet();
        }
    }
}
