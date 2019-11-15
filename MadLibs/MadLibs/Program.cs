using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            string wordEst;
            string bodyPartPlural;
            string animal;
            string noun;
            string pluralNoun;
            int a;
            int b;
            int c;

            Console.WriteLine("What is you favorite color >> ");
                color = Console.ReadLine();

            Console.WriteLine("Enter a word ending with est >> ");
            wordEst = Console.ReadLine();

            Console.WriteLine("Name a plural body part >> ");
            bodyPartPlural = Console.ReadLine();

            Console.WriteLine("Name an animal >> ");
            animal = Console.ReadLine();

            Console.WriteLine("Enter a noun >> ");
            noun = Console.ReadLine();

            Console.WriteLine("Now enter a plural noun >> ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a smaller number");
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;

            Console.WriteLine("The {0} dragon is the {1} dragon of all. It has {2} {3}, and a {4} shaped like a {5}. " +
                "It loves to eat {6}, althopugh it will feast on nearly anything.", color, wordEst, c, bodyPartPlural, animal, noun, pluralNoun);
        }
    }
}
