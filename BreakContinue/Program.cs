using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

            Console.WriteLine("Using break and continue :");
            foreach (int val in values)
            {
                if (val >= 20 && val <= 29) {
                    continue;
                }

                Console.WriteLine($"val is currently {val}");

            //    if (val >= 40) {
            //        break;
            //    }
            }
        }
    }
}