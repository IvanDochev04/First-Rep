using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();

            double hallPrice = 0;
            double discount = 0;
            double servicePrice = 0;
            double priceForPerson = 0;
            double totalPrice = 0;


            if (groupCount <= 50)
            {
                hallPrice = 2500;
                if (servicePackage == "Normal")
                {
                    discount = 0.95;
                    servicePrice = 500;
                }
                else if (servicePackage == "Gold")
                {
                    discount = 0.90;
                    servicePrice = 750;
                }
                else if (servicePackage == "Platinum")
                {
                    discount = 0.85;
                    servicePrice = 1000;
                }
                totalPrice = (hallPrice + servicePrice) * discount;
                priceForPerson = totalPrice / groupCount;

                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {priceForPerson:f2}$");
            }



            else if (groupCount <= 100)
            {
                hallPrice = 5000;
                if (servicePackage == "Normal")
                {
                    discount = 0.95;
                    servicePrice = 500;
                }
                else if (servicePackage == "Gold")
                {
                    discount = 0.90;
                    servicePrice = 750;
                }
                else if (servicePackage == "Platinum")
                {
                    discount = 0.85;
                    servicePrice = 1000;
                }
                totalPrice = (hallPrice + servicePrice) * discount;
                priceForPerson = totalPrice / groupCount;

                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {priceForPerson:f2}$");

            }

            else if (groupCount <= 120)
            {
                hallPrice = 7500;
                if (servicePackage == "Normal")
                {
                    discount = 0.95;
                    servicePrice = 500;
                }
                else if (servicePackage == "Gold")
                {
                    discount = 0.90;
                    servicePrice = 750;
                }
                else if (servicePackage == "Platinum")
                {
                    discount = 0.85;
                    servicePrice = 1000;
                }
                totalPrice = (hallPrice + servicePrice) * discount;
                priceForPerson = totalPrice / groupCount;

                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {priceForPerson:f2}$");

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }



        }
    }
}
