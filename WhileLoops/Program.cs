using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            Console.WriteLine("Basic while() loop:");
            while (inputStr != "exit") {
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
            }

            Console.WriteLine();
        }
    }
}