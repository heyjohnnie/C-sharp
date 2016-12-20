using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integrer Division
            int intA = 7;
            int intB = 2;
            int resultIntegrer = intA / intB;

            //Float Division
            float floatA = 7f;
            float floatB = 2f;
            float resultFloat = floatA / floatB;

            //Castening Division
            float resultCastening = intA / floatB;

            //Print Results
            Console.WriteLine($"Integrer result: {resultIntegrer}");
            Console.WriteLine($"Float result: {resultFloat}");
            Console.WriteLine($"Castening result: {resultCastening}");

            Console.ReadKey();
        }
    }
}
