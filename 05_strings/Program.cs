using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string wholeName = "Aurelia Carlin";
            Console.WriteLine(wholeName);

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            string firstNames = "Robin";
            string lastNames = "Holler";
            Console.WriteLine($"Her name is {firstNames} {lastNames}");

            string team = "None,";
            string okay = "I don't have a favorite team.";


            Console.WriteLine(team + " " + okay);
            Console.WriteLine($"What's your favorite team? {team} {okay}");
            Console.WriteLine("What's your favorite team? {0} {1}", team, okay);

            Console.ReadLine();
        }
    }
}
