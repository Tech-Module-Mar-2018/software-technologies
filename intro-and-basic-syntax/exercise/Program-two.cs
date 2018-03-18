using System;

namespace Problem_two
{
    class Program
    {
        static void Main(string[] args)
        {
			//program receives width input from the user
            var width = double.Parse(Console.ReadLine());
			//program receives height input from the user
            var height = double.Parse(Console.ReadLine());
			//here we calculate the area using the input from the user
            var area = width * height;
			//finally print the area result on the console
            Console.WriteLine($"{area:f2}");

        }
    }
}
