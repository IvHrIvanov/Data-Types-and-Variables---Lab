using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string sybols = Console.ReadLine();

            Console.WriteLine($"{firstName}{sybols}{lastName}");
        }
    }
}
