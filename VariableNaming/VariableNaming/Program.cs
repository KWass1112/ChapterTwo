using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 34;
            int resultAdd;
            int resultMinus;
            int resultDivide;
            int resultMultiply;
            int resultModulus;

            resultAdd = num1 + num2;
            resultMinus = num2 - num1;
            resultDivide = num2 / num1;
            resultMultiply = num2 * num1;
            resultModulus = num2 % num1;

            Console.WriteLine("The result of ${1} + ${0} = ${2}", num1, num2, resultAdd);
            Console.WriteLine("The result of ${1} - ${0} = ${2}", num1, num2, resultMinus);
            Console.WriteLine("The result of ${1} / ${0} = ${2}", num1, num2, resultDivide);
            Console.WriteLine("The result of ${1} * ${0} = ${2}", num1, num2, resultMultiply);
            Console.WriteLine("The result of ${1} % ${0} = ${2}", num1, num2, resultModulus);
        }
    }
}
