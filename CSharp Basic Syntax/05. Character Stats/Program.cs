using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int MaxEnergy = int.Parse(Console.ReadLine());

            string healthBarCurrent = new string('|', currentHealth);
            string healthBarMax = new string('.', maxHealth - currentHealth);
            string energyBarCurrent = new string('|', currentEnergy);
            string energyBarMax = new string('.', MaxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthBarCurrent}{healthBarMax}|");
            Console.WriteLine($"Energy: |{energyBarCurrent}{energyBarMax}|");


        }
    }
}
