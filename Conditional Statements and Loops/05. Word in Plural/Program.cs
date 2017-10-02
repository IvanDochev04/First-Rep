using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
      
        
            static void Main(string[] args)
            {
                string noun = Console.ReadLine();
                bool yIes = noun.EndsWith("y");
                bool oEs = noun.EndsWith("o");
                bool chEs = noun.EndsWith("ch");
                bool sEs = noun.EndsWith("s");
                bool shEs = noun.EndsWith("sh");
                bool xEs = noun.EndsWith("x");
                bool zEs = noun.EndsWith("z");


                int a = noun.Count() - 1;

                if (yIes)
                {

                    Console.WriteLine($"{noun.Remove(a, 1)}ies");
                }
                else if (oEs || chEs || sEs || shEs || xEs || zEs)
                {
                    Console.WriteLine($"{noun}es");
                }
                else
                {
                    Console.WriteLine($"{noun}s");
                }
            }
        }
    }

