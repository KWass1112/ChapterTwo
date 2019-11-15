using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KILO_TO_MILES = 1.6;
            double milesEntery = 5;
            double kilo;

            kilo = KILO_TO_MILES * milesEntery;
            Console.WriteLine("The number of miles entered was {0} and that equils {1} kilometers.", milesEntery, kilo);
        }
        public static void displayEnterActiveConversion() { 
        
            const double KILO_TO_MILES = 1.6;
            double milesEntery;
            double kilo;
            string milesEnteryString;

            Console.WriteLine("Enter miles. >>>> ");
            milesEnteryString = Console.ReadLine();
            milesEntery = Convert.ToDouble(milesEnteryString);

            kilo = KILO_TO_MILES * milesEntery;
            Console.WriteLine("The number of miles entered was {0} and that equils {1} kilometers.", milesEntery, kilo);
        }
    }
}
