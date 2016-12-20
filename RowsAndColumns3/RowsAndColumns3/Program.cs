using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsAndColumns3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every even row, must display the stars
            for (int row = 0; row < 10; row+=2)
            {
                //Every odd row, a star must be printed
                for (int column = 10; column > row + 1; column-=2)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < row + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
