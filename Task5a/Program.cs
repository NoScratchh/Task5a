using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grades;

            Console.WriteLine("Marks for Math");
            int Maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks for Chemistry");
            int Chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks for Physics");
            int Physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks for Computer Science");
            int ComputerScience = Convert.ToInt32(Console.ReadLine());

            grades = (Maths + Chemistry + Physics + ComputerScience) / 4;

            if (grades >= 80)
            {
                Console.WriteLine("Excellent! Your grade is A");
            }

            else if (grades >= 70)
            {
                Console.WriteLine("Good! Your grade is B’");
            }

            else if (grades >= 60)
            {
                Console.WriteLine("Satisfactory. Your grade is C");
            }
            else if (grades >= 50)
            {
                Console.WriteLine("Pass. Your grade is D’");
            }

            else 
            {
                Console.WriteLine("Fail. Your grade is F");
            }

            Console.ReadLine();
        }
    }
}
