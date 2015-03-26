// Assignment 1, Vinicius L. de Moraes, CIS 345, T Th 3:00 PM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Loops
    {
        static void Main(string[] args)
        {
            // Exercise 01

            Console.WriteLine("CIS 345 Assignment 1, Part 1 - Odd Numbers");

            int num = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(num + " ");
                num = num + 2;
            }

            // Exercise 02

            Console.WriteLine("\n\nCIS 345 Assignment 1, Part 2 - Even Numbers");

            num = 1;

            while (num <= 20)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
                num++;
            }

            // Exercise 03

            Console.WriteLine("\n\nCIS 345 Assignment 1, Part 3 - Factorial");
            
            Console.WriteLine("Enter a number for the factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int total = n;

            for (int i = n; i > 1; i--)
            {
                total = total * (i - 1);
            }

            Console.Write("The factorial is " + total);

            // Exercise 04

            Console.WriteLine("\n\nCIS 345 Assignment 1, Part 4 - Triangles");

            for (int i = 11; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int star = 9;
            int blank = 1;

            for (int i = 0; i < 10; i++){
                for (int j = 0; j < star; j++){
                    Console.Write(" ");
                }

                for (int j = 1; j <= blank; j++)
                {
                    Console.Write("*");
                }
                star--;
                blank++;
                Console.WriteLine();
            }

            // Exercise 05

            Console.WriteLine("\n\nCIS 345 Assignment 1, Part 5 - Multiplication Table\n");

            for (int i = 5; i <= 10; i++)
            {
                for (int j = 10; j <= 50; j+=10)
                {
                    total = i * j;
                    // Console.WriteLine(i + " x " + j + " = " + total);
                    Console.WriteLine("{0,2}{1,2}{2,3}{3,2}{4,4}", i, "x", j, "=", total);
                }
                    Console.WriteLine("\n");
            }

                Console.ReadLine();
        }
    }
}
