using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PREDICTED_RAISES = 1.04;

            double employee1;
            double employee2;
            double employee3;

            

            Console.WriteLine("Enter employee 1's salery >> ");
            employee1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter employee 2's salery >> ");
            employee2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter employee 3's salery >> ");
            employee3 = Convert.ToDouble(Console.ReadLine());

            employee1 = employee1 * PREDICTED_RAISES;

            employee2 = employee2 * PREDICTED_RAISES;

            employee3 = employee3 * PREDICTED_RAISES;

            Console.WriteLine("Employee 1,s salery is {0}", employee1);
            Console.WriteLine("Employee 2,s salery is {0}", employee2);
            Console.WriteLine("Employee 3,s salery is {0}", employee3);
        }
    }
}
