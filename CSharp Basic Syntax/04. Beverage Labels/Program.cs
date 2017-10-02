using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energy = int.Parse(Console.ReadLine());
            double sugar = int.Parse(Console.ReadLine());

            double countOfVolume = volume / 100;

            double energyContent = energy * countOfVolume;
            double sugarContent = sugar * countOfVolume;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");


        }
    }
}