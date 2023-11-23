using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

         //   Console.WriteLine("The basic for loop:");
         //   for (int i = 0; i < myVal; i++) {
         //       Console.WriteLine("i is currently {0}", i);
         //   }
            Console.WriteLine();

        //    foreach (int i in nums) {
        //        Console.WriteLine("i is currently {0}", i);
        //    }
            var count = 0;
            foreach (char c in str) {
                if (c == 'o') {
                    count++;
                }
            }
            Console.WriteLine("Counted {0} o character", count);
        }
    }
}
