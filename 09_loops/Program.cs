using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while(number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }

            int numbers = 100;
            for (int i = 1; i <= numbers; i++)
            {
                Console.WriteLine(i);
            }

            int five = 525;
            for (int j = 500; j <= five; j += 5)
            {
                Console.WriteLine(j);
            }

            int one = 100;
            for(int s = 0; s <= one; s += 5)
            {
                Console.WriteLine(s);
            }
            int fizzBuzz = 100;

            for(int k = 0; k <= fizzBuzz; k++)
            {
                if(k % 15 == 0)
                {
                    Console.WriteLine("Fizz buzz");
                }
                else if(k % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(k % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(k);
                }
            }


            Console.ReadLine();
        }
    }
}
