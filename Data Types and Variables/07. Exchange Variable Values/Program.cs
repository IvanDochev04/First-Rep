using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int reminder = a;
           
            Console.WriteLine("Before:");
            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = "+ b);
            a = b;
            b = reminder;

            Console.WriteLine("After:");
            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = "+ b);
        }
    }
}
