using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            for (int i = 1; i <= a; i++)
            {
                for (int f = 1; f < i; f++)
                {
                    Console.Write($"{i} ");
                }


                Console.WriteLine(i);
            }

        }
    }
}