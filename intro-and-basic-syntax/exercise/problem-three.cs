//CONFIRMED from warum
using System;

namespace problem_three
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometers = double.Parse(Console.ReadLine());
            var mile = 1.60934 * kilometers;
            Console.WriteLine($"{mile:f2}");
        }
    }
}
