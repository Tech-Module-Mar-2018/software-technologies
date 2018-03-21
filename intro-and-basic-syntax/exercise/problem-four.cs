//CONFIRMED from tedoo
using System;

namespace solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            //read food product
            string name = Console.ReadLine();
            int drinkVolume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            //calculate the energy and sugar content for the given drinkVolume
            Console.WriteLine("{0}ml {1}:", drinkVolume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", (drinkVolume / 100.0) * energyContent, (drinkVolume / 100.0) * sugarContent);
        }
    }
}