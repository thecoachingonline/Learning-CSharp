using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

            Console.WriteLine(str1.Length);

            Console.WriteLine(str1[14]);

            foreach (char ch in str1) {
                Console.Write(ch);
                if (ch == 'b')
                {
                    Console.WriteLine();
                    break;
                }
            }
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);

            outstr = String.Join('.', strs);
            Console.WriteLine(outstr);

            outstr = String.Join("---", strs);
            Console.WriteLine(outstr);
        }
    }
}