using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Methods
    {
        //Method 1
        static private int Add(int number1, int number2)
        {
            return (number1 + number2);
        }

        //Method 2
        static private double Add(int number1, int number2, double number3)
        {
            return (number1 + number2 + number3);
        }

        //Method 3
        static private string Concatenate(string string1, string string2)
        {
            return (string1 + string2);
        }

        //Method 4
        static private string Concatenate(int number1, int number2)
        {
            string outputText;

            outputText = Methods.Concatenate(number1.ToString(), number2.ToString());
            return (outputText);
        }

        //Method 5
        static private bool IsEven(int number)
        {
            if(number % 2 == 0){
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //Method 6
        static private double Divide(int number1, int number2)
        {
            double quotient = 0.0;
            quotient = (double) number1 / number2;

            return (quotient);
        }

        //Method 7
        static private int Divide(int number1, int number2, ref int quotient, ref int reminder)
        {
            quotient = number1 / number2;
            reminder = number1 % number2;
            return (0);
        }

        //Method 8
        static private int Multiply(int number1, int number2 = 1, int number3 = 1)
        {
            int product;

            product = number1 * number2 * number3;
            return (product);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("***  Using Overloded Methods  ***");
            
            //part 1: 'add' method
            int additionResult;
            additionResult = Methods.Add(5, 2);
            Console.WriteLine("The sum of 5 and 2 is {0}.", additionResult);
            Console.WriteLine("The sum of 5, 5 and 2.5 is {0:f2}", Methods.Add(5, 5, 2.5));
            
            Console.WriteLine("\n4 and 2 concatenated is {0}", Methods.Concatenate(4, 2));
            Console.WriteLine("\n\"4\" and \"2\" concatenated is {0}", Methods.Concatenate("4", "2"));

            //part 2: even or odd test
            Console.WriteLine("\n***  Processing boolean return values  ***");
            bool numberIsEven = false;
            Console.WriteLine("Testing if the number 4 is even or odd...");
            numberIsEven = Methods.IsEven(4);

            if (numberIsEven == true)
            {
                Console.WriteLine("4 is even.");
            }
            else
            {
                Console.WriteLine("4 is odd.");
            }

            Console.WriteLine("\nTesting if the number 5 is even or odd...");
            numberIsEven = Methods.IsEven(5);

            if (numberIsEven == true)
            {
                Console.WriteLine("4 is even.");
            }
            else
            {
                Console.WriteLine("4 is odd.");
            }

            Console.WriteLine("\n***  Passing parameters by-value vs by-reference  ***");

            //part 3: 'divide' method
            double divisionResult;
            divisionResult = Methods.Divide(7, 6);
            Console.WriteLine("7/6 is {0:f4}", divisionResult);

            int number1 = 7;
            int number2 = 6;
            int quotient = 0;
            int reminder = 0;

            divisionResult = Methods.Divide(number1, number2, ref quotient, ref reminder);
            Console.WriteLine("7/6: Quotient is {0}. Reminder is {1}.", quotient, reminder);

            Console.WriteLine("\n***  Using required and optional arguments  ***");

            //part 4: optional and required arguments
            int product;
            product = Methods.Multiply(5);
            Console.WriteLine("Calling multiply with 1 argument: 5");
            Console.WriteLine("Product is {0}", product);

            product = Methods.Multiply(5, 2);
            Console.WriteLine("\nCalling multiply with 1 argument: 5 and 2");
            Console.WriteLine("Product is {0}", product);

            product = Methods.Multiply(5, 2, 3);
            Console.WriteLine("\nCalling multiply with 1 argument: 5, 2 and 3");
            Console.WriteLine("Product is {0}", product);

            Console.ReadLine();
        }
    }
}
