using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Even and Odd calculator");

            //First number input and conversion to integrer
            Console.WriteLine("Please enter a number: ");
            string numAsText = Console.ReadLine();
            int num = Convert.ToInt32(numAsText);

            //Defining boolean levels, 0 is even and 1 is odd
            bool remain = (num % 2) > 0;

            //Evaluating true/false statements
            if (remain == true)
                Console.WriteLine($"{num} is an odd number");

            else
                Console.WriteLine($"{num} is an even number");
            
            Console.ReadKey();
        }
    }
}
