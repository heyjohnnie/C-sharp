using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to basic Calculator 1.0");

            //User inputs two numbers to calculate
            Console.WriteLine("Please enter the first number: ");
            string firstNumberAsText = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            string secondNumberAsText = Console.ReadLine();

            //User input and conversion to char
            Console.WriteLine("Please type '+' for adition, '-' for subtraction," +
                " * for multiplication, '/' for division, % for remainder and '^' for power");
            string operandAsText = Console.ReadLine();
            char operand = Convert.ToChar(operandAsText);

            //Converting user input into usable variables for math
            double firstNumber = Convert.ToDouble(firstNumberAsText);
            double secondNumber = Convert.ToDouble(secondNumberAsText);
                       
            switch (operand)
            {
                case '+':
                    Console.WriteLine($"The result is: {firstNumber + secondNumber}");
                    break;

                case '-':
                    Console.WriteLine($"The result is: {firstNumber - secondNumber}");
                    break;

                case '*':
                    Console.WriteLine($"The result is: {firstNumber * secondNumber}");
                    break;

                case '/':
                    Console.WriteLine($"The result is: {firstNumber / secondNumber}");
                    break;

                case '%':
                    Console.WriteLine($"The result is: {firstNumber % secondNumber}");
                    break;

                case '^':
                    Console.WriteLine($"The result is: {Math.Pow(firstNumber, secondNumber)}");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
