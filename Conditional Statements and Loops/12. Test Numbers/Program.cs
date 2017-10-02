using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int result = 0;
            int numberOfCombinations = 0;
            if (n >= 1 && n <= 100 && m >= 1 && m <= 100 && boundary >= 1 && boundary <= 1000000)
            {
                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        result = (i * j) * 3;
                        totalSum += result;
                        numberOfCombinations++;
                        if (totalSum >= boundary)
                        {
                            break;
                        }

                    }
                    if (totalSum >= boundary)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{numberOfCombinations} combinations");
                if (totalSum >= boundary)
                {
                    Console.WriteLine($"Sum: {totalSum} >= {boundary}");
                }
                else
                {
                    Console.WriteLine($"Sum: {totalSum}");
                }
            }
        }
    }
}

