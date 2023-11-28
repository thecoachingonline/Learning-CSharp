using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            b1._name = "Aldous Huxley";
        }
    }
}