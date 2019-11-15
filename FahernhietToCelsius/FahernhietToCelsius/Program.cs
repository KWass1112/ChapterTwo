using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahernhietToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahernhiet;
            double celsius;

            Console.WriteLine("Enter a temp in fahernhiet >> ");
            fahernhiet = Convert.ToDouble(Console.ReadLine());
            celsius = (fahernhiet - 32) * 5 / 9;
            Console.WriteLine("{0} degrees fahernhiet is {1} degrees celsius", fahernhiet, celsius);
        }
    }
}
