using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationWithSigns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Positive or Negative");

            //First input
            Console.WriteLine("Please, enter the first number: ");
            string firstNumberAsText = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberAsText);

            //Second number
            Console.WriteLine("Please, enter the second number: ");
            string secondNumberAsText = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberAsText);

            //Defining boolean conditions for both signs, positive is true 
            //and negative is false.
            bool firstSign = firstNumber > 0;
            bool secondSign = secondNumber > 0;

            if ((firstSign == false) && (secondSign == false))
                Console.WriteLine($"The result of the multiplication between {firstNumber} and {secondNumber} will be positive.");

            else if ((firstSign == true) && (secondSign == true))
                Console.WriteLine($"The result of the multiplication between {firstNumber} and {secondNumber} will be positive.");

            else
                Console.WriteLine($"The result of the multiplication between {firstNumber} and {secondNumber} will be negative.");

            //Console.WriteLine($"The typed number is: {firstNumber}");
            Console.ReadKey();
        }
    }
}
