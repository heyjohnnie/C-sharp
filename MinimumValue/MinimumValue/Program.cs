using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the array
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            //We set a high number to evaluate the for loop
            int currentMinimum = Int32.MaxValue;

            //We start entering in each array index and each value is evaluated against
            //the current minimum and if it's true, it replaces the current minimum value
            for (int numbers = 0; numbers < array.Length; numbers++)
            {
                if (array[numbers] < currentMinimum)
                    currentMinimum = array[numbers];
            }

            Console.WriteLine(currentMinimum);
            Console.ReadKey();
        }
    }
}
