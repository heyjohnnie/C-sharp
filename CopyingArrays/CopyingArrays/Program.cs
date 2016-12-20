using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the values to copy
            int[] sender = new int[] { 4, 89, -8, 69, -54, 3, -6, 17, -32, 26 };
            //Declaring the receiver length
            int[] receiver = new int[10];

            //We access every index from the  sender, and copy each value into the desired index of the receiver.
            for (int index = 0; index < sender.Length; index++)
            {
                receiver[index] = sender[index];
                Console.WriteLine(receiver[index]);
            }
            Console.ReadKey();
        }
    }
}
