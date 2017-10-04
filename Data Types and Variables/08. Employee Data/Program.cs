using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Amanda
            //Jonson
            //27
            //f
            //8306112507
            //27563571
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            //First name: Amanda
            //Last name: Jonson
            //Age: 27
            //Gender: f
            //Personal ID: 8306112507
            //Unique Employee number: 27563571


            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+ age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+ personalID);
            Console.WriteLine("Unique Employee number: "+ employeeNumber);
        }
    }
}
