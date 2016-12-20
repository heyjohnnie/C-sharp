using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[2];
            matrix[1] = new int[6];
            matrix[2] = new int[5];
            matrix[3] = new int[7];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.Write(matrix[row][column] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
