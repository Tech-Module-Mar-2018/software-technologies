//COMFIRMTED from ivanborisovg
using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
			//input first part of card digits
            var theFirst = int.Parse(Console.ReadLine());
			//input second part of card digits
            var theSecond = int.Parse(Console.ReadLine());
			//input third part of card digits
            var theThird = int.Parse(Console.ReadLine());
			//input fourth part of card digits
            var theFourth = int.Parse(Console.ReadLine());
			//print result with leading zeroes if needed
            Console.Write($"{theFirst:D4} {theSecond:D4} {theThird:D4} {theFourth:D4}");

        }
    }
}
