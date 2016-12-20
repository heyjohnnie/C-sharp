using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Option selection
            Console.WriteLine("Please select a number between 1 and 5: ");
            string optionAsText = Console.ReadLine();
            int selectedOption = Convert.ToInt32(optionAsText);

            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine($"You chose option {selectedOption}");
                    break;

                case 2:
                    Console.WriteLine($"Option {selectedOption} is nice too.");
                    break;

                case 3:
                    Console.WriteLine($"I'd chose option {selectedOption} too");
                    break;

                case 4:
                    Console.WriteLine($"You shouldn't have picked option {selectedOption}");
                    break;

                case 5:
                    Console.WriteLine($"Option {selectedOption} isn't my favorite");
                    break;

                default:
                    Console.WriteLine($"{selectedOption} is not a valid option!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
