﻿//CONFIRMED from ralijordanova
using System;

namespace Problem_two
{
    class Program
    {
        static void Main(string[] args)
        {
			//program receives width input from the user 
            double widthDouble = double.Parse(Console.ReadLine()); //changed variable
			//program receives height input from the user
            var height = double.Parse(Console.ReadLine());
			//here we calculate the area using the input given from the user
            var area = widthDouble * height; //changed variable
			//finally print the area result on the console
            Console.WriteLine($"{area:f2}");

        }
    }
}
