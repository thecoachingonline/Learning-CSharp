using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            StringBuilder sb = new StringBuilder("Initial string.", 200);

            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
        }
    }
}