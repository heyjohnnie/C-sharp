using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsAndColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            //First loop determines rows height
            for (int row = 0; row < 5; row++)
            {
                //Second Loop prints character n times in a row.
                for (int column = 0; column < 10; column++)
                {
                    Console.Write("*");
                }

                //After condition in 2nd loop is completed, this code jumps to the next one
                Console.WriteLine();
            }

            //When finished, type a key to exit
            Console.ReadKey();
        }
    }
}
