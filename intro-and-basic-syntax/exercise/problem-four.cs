using System;

namespace solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            //read food product
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            //calculate the energy and sugar content for the given volume
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", (volume / 100.0) * energyContent, (volume / 100.0) * sugarContent);
        }
    }
}