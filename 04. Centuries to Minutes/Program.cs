﻿using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int years = input * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{input} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");

        }
    }
}
