﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            decimal kilometers = (decimal)meters/1000;
            
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
