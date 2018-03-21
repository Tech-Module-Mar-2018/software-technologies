//COMFIRMTED from ivanborisovg
using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var fourth = int.Parse(Console.ReadLine());

            Console.Write($"{first:D4} {second:D4} {third:D4} {fourth:D4}");

        }
    }
}
