using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfTheYear
{
    // Defining the list with indeces > 0
    public enum Months {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December =12 };

    class Program
    {
        static void Main(string[] args)
        {
            int NumberInput;

            // Looping until user enters "e"
            do {

                Console.WriteLine("Please enter a number between 1 and 12, or press 'e' to exit");
                string userInput = Console.ReadLine();

                if ((userInput == "e") || (userInput == "E")) //If the user types "e", the program exits
                {
                    break;
                }
                else
                {
                    // TryParse is used to convert string to int, if it fails, it'll return a boolean false, and defines a number outside the valid options
                    bool TextOrString = int.TryParse(userInput, out NumberInput);

                    if ((TextOrString == false) || (NumberInput == 0))
                    {
                        NumberInput = 13;
                    }

                    // Converting the NumberInput to the enum variables
                    Months NumberOfMonth = (Months)NumberInput;

                    switch (NumberInput)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                            Console.WriteLine(NumberOfMonth);
                            break;

                        default:
                            Console.WriteLine("That's not a valid option");
                            break;
                    } //End of switch
                }  //End of else
            } //End of do

            while (NumberInput > 0); //NumberInput will never be 0, creating a semi-infinite loop
        }
    }
}
