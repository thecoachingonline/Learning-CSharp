using System;

namespace Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            Console.WriteLine("The car is a {0} {1} {2} , with {3} miles and costs ${4}", year, make, model, miles, price);

            Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs {price:C2}");

            Console.WriteLine($"This car is a {year} {make} {model}, with {miles * 1.6:F2} km and costs {price:C2}");
        }
    }
}