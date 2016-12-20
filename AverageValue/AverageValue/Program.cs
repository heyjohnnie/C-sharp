using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the array
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            //We set the starting value of the result of the addition
            int total = 0;

            //We enter into each array index and we add the value stored to the previous value
            /*for (int index = 0; index < array.Length; index++)
                total += array[index];*/

            foreach (int number in array)
            {
                total += number;
            }

            //Converting into float
            float average = (float)total / array.Length;
            Console.WriteLine(average);
            Console.ReadKey();

        }
    }
}
