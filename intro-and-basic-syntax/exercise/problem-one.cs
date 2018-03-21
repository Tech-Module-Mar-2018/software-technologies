//COMFIRMTED from ivanborisovg
using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
			//input first part of card digits
            var first = int.Parse(Console.ReadLine());
			//input second part of card digits
            var second = int.Parse(Console.ReadLine());
			//input third part of card digits
            var third = int.Parse(Console.ReadLine());
			//input fourth part of card digits
            var fourth = int.Parse(Console.ReadLine());
			//print result with leading zeroes if needed
            Console.Write($"{first:D4} {second:D4} {third:D4} {fourth:D4}");

        }
    }
}
