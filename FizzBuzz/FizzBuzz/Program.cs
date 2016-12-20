using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string message = "";

                if ((i % 3 == 0) && (i % 5 == 0))
                    message = "FizzBuzz";

                else if (i % 3 == 0)
                    message = "Fizz";

                else if (i % 5 == 0)
                    message = "Buzz";

                else
                    message = Convert.ToString(i);

                Console.WriteLine(message);
            }
                        
            Console.ReadKey();
        }
    }
}
