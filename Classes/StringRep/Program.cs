using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            Console.WriteLine(x.ToString());

        //    object a = new object();
        //    Console.WriteLine(a.ToString());

            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1);

            Console.WriteLine(b1.ToString('B'));
            Console.WriteLine(b1.ToString('F'));
        }
    }
}