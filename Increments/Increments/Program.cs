using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = ++a; //Both 'a' and 'b' will be 4.

            int c = 3;
            int d = c++; //The original value of 3 is assigned to 'd', while 'c' is now 4.

            //Show the difference between prefix and postfix
            Console.WriteLine($"Prefix notation increment. For a = {a} and b = {b}");
            Console.WriteLine("Postfix notation increment. For c = {0} and d = {1}", c, d);

            Console.ReadKey();
        }
    }
}
