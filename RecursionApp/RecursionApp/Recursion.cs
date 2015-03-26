// In class exercise 4, Vinicius L. de Moraes, CIS 345, T Th 3:00 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionApp
{
    class Recursion
    {

        private static int FactorialWithRecursion(int n)
        {
            int factorial;

            if (n > 1)
            {
                factorial = n * FactorialWithRecursion(n - 1);
            }
            else
            {
                return 1;
            }

            return factorial;
        }

        private static int PowerWithRecursion(int b, int e)
        {
            int power;

            if (e > 0)
            {
                power = b * (int) Math.Pow(b, e-1);
            }
            else
            {
                return (1);
            }

            return (power);
        }

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("***  Factorial with Recursion  ***\n\n");
            Console.WriteLine("Type a integer number for the factorial: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factorial result is {0}",  Recursion.FactorialWithRecursion(n));
            Console.ReadLine();

            int b;
            int e;

            Console.WriteLine("***  Power with Recursion  ***\n\n");
            Console.WriteLine("Type a integer number for the base: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a integer number for the exponent: ");
            e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The power result is {0}", Recursion.PowerWithRecursion(b, e));
            Console.ReadLine();

        }
    }
}
