using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            decimal accountBalance = 800000.30m;
            Console.WriteLine(accountBalance);

            int isNumber = 23;
            Console.WriteLine(isNumber);

            float isFloat = 3.33f;
            Console.WriteLine(isFloat);

            double isDouble = 15.25456d;
            Console.WriteLine(isDouble);

            int isInt = -3500;
            Console.WriteLine(isInt);

            string isString = "Hi!";
            Console.WriteLine(isString);
           
            Console.ReadLine();
        }
    }
}
