using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 5;
            string a = "abcd", b = "efgh";

            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            Console.WriteLine("----- Shorthand -----");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            a += b;
            Console.WriteLine(a);
        }
    }
}