using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationsExample
{
    //You define enumerations directly in the namespace
    enum DaysOfTheWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek today = DaysOfTheWeek.Thursday;

            //Enumerations have int values, starting from 0
            int dayAsInt = (int)today;

            if (dayAsInt == 4)
                Console.WriteLine(today);

            Console.ReadKey();
        }
    }
}
