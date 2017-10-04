using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
           short centure = short.Parse(Console.ReadLine());
            int years = centure * 100;
            double days = (int)years * 365.2422;
            int hours = (int)days * 24;
            long minutes = (long)hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            ulong microseconds = (ulong)milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centure} centuries = {years} years = {Math.Floor(days)} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {microseconds}000 nanoseconds");



        }
    }
}
