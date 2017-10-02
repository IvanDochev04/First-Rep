using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double calories = 0;
            for (int i = 0; i < a; i++)
            {
                string ingrediant = Console.ReadLine().ToLower();
                if (ingrediant == "cheese")
                {
                    calories += 500;
                }

                else if (ingrediant == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingrediant == "salami")
                {
                    calories += 600;
                }
                else if (ingrediant == "pepper")
                {
                    calories += 50;
                }

            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}

