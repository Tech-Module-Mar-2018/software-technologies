//CONFIRMED from tedoo
using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive the input data
            var currentName = Console.ReadLine();
            var Health = int.Parse(Console.ReadLine());
            var currenMaxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var currentMaxEnergy = int.Parse(Console.ReadLine());
            // Print the name
            Console.WriteLine($"Name: {currentName}");
            //Print the health
            Console.Write("Health: |");
            for (int i = 1; i <= Health; i++)
            {
                Console.Write("|");
            }
            for (int i = 1; i <= currenMaxHealth - Health; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");
            Console.WriteLine();
            // Print the energy
            Console.Write("Energy: |");
            for (int i = 1; i <= energy; i++)
            {
                Console.Write("|");
            }
            for (int i = 1; i <= currentMaxEnergy - energy; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");

        }
    }
}
