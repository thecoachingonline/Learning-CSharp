using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            string str = "a string";

            var x = 10;
            var z = "Hello!";

            int[] vals = new int[5];
            string[] strs = {"one", "two", "three"};

            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,c,b,str,f,d,x,z);
        }
    }
}