using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are your friends like?");
            string myFriend = Console.ReadLine().ToLower();

            switch(myFriend)
            {
                case "bethany":
                    Console.WriteLine("Bethany is the most thoughtful person I know");
                    break;
                case "lindsay":
                    Console.WriteLine("Lindsay always smiles!");
                    break;
                case "abigail":
                    Console.WriteLine("Abigail is a hair dresser");
                    break;
                case "hope":
                    Console.WriteLine("Hope is super easy to talk to");
                    break;
                default:
                    Console.WriteLine("I'm not sure who that is");
                    break;
            }





            Console.ReadLine();



            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            switch(inputName)
            {
                case "fred":
                    Console.WriteLine("Hey Fred, let's go golfine.");

                    break;
                case "karl":
                    Console.WriteLine("Let's hang.");
                    break;
                case "john":
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default:
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    break;

            }
            
        }
    }
}
