using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            double disscount = 1;

            double totalPriceOfStudio = 0;
            double totalPriceOfDouble = 0;
            double totalPriceOfSuite = 0;

            double nightCounts = nightsCount;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nightsCount > 7)
                {
                    disscount = 0.95;

                }
                if (month == "October" && nightsCount > 7)
                {
                    nightCounts = nightsCount - 1;
                }
                totalPriceOfStudio = (studioPrice * disscount) * nightCounts;
                totalPriceOfDouble = (doublePrice) * nightsCount;
                totalPriceOfSuite = (suitePrice) * nightsCount;

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    disscount = 0.9;

                }
                if (month == "September" && nightsCount > 7)
                {
                    nightCounts = nightsCount - 1;
                }
                totalPriceOfStudio = (studioPrice) * nightCounts;
                totalPriceOfDouble = (doublePrice * disscount) * nightsCount;
                totalPriceOfSuite = (suitePrice) * nightsCount;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightsCount > 14)
                {
                    disscount = 0.85;
                }
                totalPriceOfStudio = (studioPrice) * nightsCount;
                totalPriceOfDouble = (doublePrice) * nightsCount;
                totalPriceOfSuite = (suitePrice * disscount) * nightsCount;

            }


            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");


        }
    }
}

