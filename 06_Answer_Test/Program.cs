using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Answer_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess what number I am thinking of? It is between 1-20");
            int guessNumber = 15;
            if (guessNumber <= 7 && guessNumber >= 1)
            {
                Console.WriteLine("You need to go much higher!");
            }
            else if (guessNumber <= 14 && guessNumber > 7)
            {
                Console.WriteLine("Little bit higher!");
            }
            else if (guessNumber == 15)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
            }
            else if (guessNumber >= 16 && guessNumber <= 20)
            {
                Console.WriteLine("Oops, little bit lower");
            }
            else
            {
                Console.WriteLine("Did you read the instructions?");
            }
            

            string guestInput = Console.ReadLine();
            if (guestInput == "Hello")
            {
                Console.WriteLine("Hello to you too!");
            }

            Console.ReadLine();

        }
    }
}
