using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars= 20;
            double cents= 1.25;
            int days;
            double miles;
            double total;


            Console.WriteLine("How many days do you drive the car >> ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many miles do you drive the car >> ");
            miles = Convert.ToDouble(Console.ReadLine());

            dollars = dollars * days;
            cents = cents * miles;
            total = dollars + cents;

            Console.WriteLine("Your total is {0}", total);
        }
    }
}
