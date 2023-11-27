using System;

namespace RefAndOutParams {

    class Program {

        static void TestFunc1(int arg1) {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        static void TestFunc2(ref int arg1) {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        static void PlusTime(int arg1, int arg2, out int sum, out int product) {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        static void Main(string[] args) {
            int val1 = 10;
            int val2 = 20;

            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            TestFunc2(ref val1);
            Console.WriteLine($"{val1}");

            int a, b;
            PlusTime(val1, val2, out a, out b);
            Console.WriteLine($"{a}, {b}");
        }
    }
}