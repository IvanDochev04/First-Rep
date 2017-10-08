using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            // a e u o y i 
            char a = 'a';
            char e = 'e';
            char u = 'u';
            char o = 'o';
            char i = 'i';
            char y = 'y';

            char zero = '0';
            char one = '1';
                char two = '2';
            char three = '3';
            char four = '4';
            char five = '5';
            char six = '6';
            char seven = '7';
            char eight = '8';
            char nine = '9';

            if (symbol == a || symbol == e || symbol == u || symbol == o || symbol == i || symbol == y)
            {
                Console.WriteLine("vowel");

            }
            else if (symbol == zero|| symbol ==one|| symbol ==two|| symbol ==three|| symbol ==four|| symbol ==five|| symbol ==six|| symbol ==seven|| symbol ==eight|| symbol ==nine)
            {
                Console.WriteLine("digit");

            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
