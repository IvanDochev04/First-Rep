using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (int a = 0; i <= 100; i++)
            {


                string x = Console.ReadLine();
                int value;
                if (int.TryParse(x, out value))
                {

                }
                else
                {
                    break;

                }

            }
            Console.WriteLine(i);
        }
    }
}

