using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dolars = 1.31M;

            decimal input = decimal.Parse(Console.ReadLine());

            decimal calculation = input * dolars;
            Console.WriteLine($"{calculation:f3}");

        }
    }
}
