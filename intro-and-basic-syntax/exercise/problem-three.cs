//CONFIRMED from warum
using System;

namespace problem_three
{
    class Program
    {
        static void Main(string[] args)
        {   // Read and parse to floating point the current input
            var kilometers = double.Parse(Console.ReadLine());
            // Convert the kilometers to miles
            var miles = 1.60934 * kilometers;
            //Print the input
            Console.WriteLine($"{miles:f2}");
        }
    }
}
