using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatementScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            int score = Convert.ToInt32(scoreAsText);

            if (score == 100)
                Console.WriteLine("Congratulations! Perfect Score!");

            else if (score > 100)
                Console.WriteLine("Please, enter a score between 0 and 100.");

            else if (score >= 90)
                Console.WriteLine("You got an A.");

            else if (score >= 80)
                Console.WriteLine("You got a B.");

            else if (score >= 70)
                Console.WriteLine("You got a C.");

            else if (score >= 60)
                Console.WriteLine("You got a D:");

            else
                Console.WriteLine("You got a F.");

            Console.ReadKey();
            
        }
    }
}
