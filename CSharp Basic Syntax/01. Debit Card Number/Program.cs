  using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DebitCardNumber
    {
        class Program
        {
            static void Main(string[] args)
            {

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());

                string a1 = new string('0', 4 - a.ToString().Count());
                string b1 = new string('0', 4 - b.ToString().Count());
                string c1 = new string('0', 4 - c.ToString().Count());
                string d1 = new string('0', 4 - d.ToString().Count());



                Console.WriteLine($"{a1}{a} {b1}{b} {c1}{c} {d1}{d}");

            }
        }
    }
