﻿using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double dul, sh, V, A = 0;
            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            V = double.Parse(Console.ReadLine());

            A = (dul * sh * V) / 3;
            Console.WriteLine($"Pyramid Volume: {A:f2}");


        }
    }
}
