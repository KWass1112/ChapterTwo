using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PREDICTED_RAISES = 1.04;
            
            double employee1 = 25000;
            double employee2 = 30000;
            double employee3 = 22000;

            employee1 = employee1 * PREDICTED_RAISES;
            employee2 = employee2 * PREDICTED_RAISES;
            employee3 = employee3 * PREDICTED_RAISES;

            Console.WriteLine("Employee 1,s salery is {0}. Employee 2,s salery is {1}. Employee 3,s salery is {2}.", employee1, employee2, employee3);

            
        }
    }
}
