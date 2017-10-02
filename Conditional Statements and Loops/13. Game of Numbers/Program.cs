using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int matchCounter = 0;
            int sum = 0;
            int counter = 0;
            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                        matchCounter++;
                        return;
                    }
                }
            }
            if (matchCounter == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
