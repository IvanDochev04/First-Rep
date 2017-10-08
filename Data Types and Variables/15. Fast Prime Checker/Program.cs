using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= number; i++)
            {
                bool ifPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {


                    if (i%j==0)
                    {
                        ifPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {ifPrime}"); 
            }
         
            
        }
    }
}
