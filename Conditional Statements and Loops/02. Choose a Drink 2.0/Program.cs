using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (profession == "Athlete")
            {

                totalPrice = price * 0.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");

            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {

                totalPrice = price * 1;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "SoftUni Student")
            {

                totalPrice = price * 1.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else
            {

                totalPrice = price * 1.2;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
        }
    }
}