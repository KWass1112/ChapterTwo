using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bossName;
            Boolean areNamesTheSame;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter the name of your boss", name);
            bossName = Console.ReadLine();
            areNamesTheSame = name == bossName;
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);



            int first, second, product;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter an integer", name);
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            second = Convert.ToInt32(Console.ReadLine());
            product = first * second;
            Console.WriteLine("Thank you {0}. The product of {1} and {2} is {3}",
           name, first, second, product);



            const double WITHHOLDING_RATE = 12;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, net;
            Console.WriteLine("Enter the number of hours you worked this week ");
            hoursAsString = Console.ReadLine();
            Console.WriteLine("Enter your hourly rate ");
            rateAsString = Console.ReadLine();

      hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);
            gross = hours * rate;
            net = gross - WITHHOLDING_RATE;
            Console.WriteLine("You worked {0} hours at {1} per hour",
           hours, rate.ToString());
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C"));

            string entry;
            int enteredInteger;
            int more;
            int less;
            Console.WriteLine("Enter an integer ");
            entry = Console.ReadLine();
            Console.WriteLine("You entered {0}", entry);
            enteredInteger = Convert.ToInt32(entry);
            more = enteredInteger + 1;
            less = enteredInteger - 1;
            Console.WriteLine("One more than {0} is {1} and one less than {2} is {3}",
           enteredInteger, more, less);
        }
    }
}
