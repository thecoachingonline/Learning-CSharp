using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Cosole.WriteLine(b1.ISBN);
            Cosole.WriteLine(b1.Price);

            b1.Name = "Crime and Punishment";
            b1.Pagecount = 652;
            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Pagecount);
        }
    }
}