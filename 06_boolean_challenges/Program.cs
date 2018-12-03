using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 101 % 2;
            if (value == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int number = 4;
            int userInput = 4;
            if (number == userInput)
            {
                Console.WriteLine("Correct!");
            }
            if (userInput < number)
            {
                Console.WriteLine("Number is too low");
            }
            if (userInput > number)
            {
                Console.WriteLine("Number is too high");
            }
            Console.ReadLine();
        }
    }
}
