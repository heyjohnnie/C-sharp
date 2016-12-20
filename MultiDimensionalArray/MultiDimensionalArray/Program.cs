using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
