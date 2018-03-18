using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            for (int i = 1; i <= currentHealth; i++)
            {
                Console.Write("|");
            }
            for (int i = 1; i <= maxHealth - currentHealth; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");
            Console.WriteLine();

            Console.Write("Energy: |");
            for (int i = 1; i <= currentEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = 1; i <= maxEnergy - currentEnergy; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");

        }
    }
}
