﻿using System;

namespace Problem_two
{
    class Program
    {
        static void Main(string[] args)
        {

            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            Console.WriteLine($"{area:f2}");

        }
    }
}
