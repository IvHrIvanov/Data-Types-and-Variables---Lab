﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            decimal calculation = (decimal)input/ 1000;

            Console.WriteLine($"{calculation:f2}");

        }
    }
}
