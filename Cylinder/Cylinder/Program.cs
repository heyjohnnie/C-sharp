using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting message
            Console.WriteLine("Welcome to Cylinder Calculator 1.0");

            //Get the Cylinder'r radius from user input
            Console.WriteLine("Enter the cylinder's radius");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            //Get the Cylinder's height from user input
            Console.WriteLine("Enter the cylinder's height");
            string heightAsString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsString);

            double pi = 3.141592654;

            //Calculate volume
            double volume = pi * radius * radius * height;

            //Calculate surface
            double surface = 2 * pi * radius * (radius + height);

            //Output the results
            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units");
            //Using String Interpolation
            Console.WriteLine($"The cylinder's surface is: {surface} square units");

            Console.ReadKey();
        }
    }
}
