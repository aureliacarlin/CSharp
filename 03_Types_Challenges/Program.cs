using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int isNumber = 68;
            int isInteger;
            Console.WriteLine(isNumber);

            string isWord = "Hey there!";
            string isString;
            Console.WriteLine(isWord);

            bool isBoolean = true;
            bool isFalse;
            Console.WriteLine(isBoolean);

            float isFloat = 198.99f;
            float notFloat;
            Console.WriteLine(isFloat);

            double isDouble = 1.00000000000d;
            double notDouble;
            Console.WriteLine(isDouble);

            decimal isDecimal = 112222.8888888888888888m;
            decimal notDecimal;
            Console.WriteLine(isDecimal);

            string helloThere = "Hi there, my name is ";

            string myName = "Aurelia";

            Console.WriteLine(helloThere + myName);

            string one = "1";
            string year = "9";
            string month = "9";
            string day = "9";

            int bYear = Int32.Parse("1999");
            Console.WriteLine("I was born in  ", bYear);

            Console.WriteLine(one + year + month + day);

            Console.ReadLine();
        }
    }
}
