using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dozenEggs = 12;
            int numEggs = 127;
            int cartonOfEggs;
            int eggsRemaining;

            cartonOfEggs = numEggs / dozenEggs;
            eggsRemaining = numEggs % dozenEggs;

            Console.WriteLine("The number of eggs collected was {0} and, we have");
        }
    }
}
