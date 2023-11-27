using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            (int a, int b) tup1 = (5,10);
            var tup2 = ("Some text", 10.5f);

            tup1.b = 20;
            tup2.Item1 = " New String";
            Console.WriteLine($"{tup1.a}, {tup1.b}");
            Console.WriteLine($"{tup2.Item1}, {tup2.Item2}");

            (int, int) result = PlusTimes(6, 12);
            Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");
        }

        static (int, int) PlusTimes(int a, int b) {
            return (a+b, a*b);
        }
    }
}