﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsAndColumns2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < row + 1; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
