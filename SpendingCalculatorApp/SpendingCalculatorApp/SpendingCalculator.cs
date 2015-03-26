using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendingCalculatorApp
{
    class SpendingCalculator
    {
        private static int CalculatePerDiem(int dollars, ref int change, int days = 5){
            change = dollars % days;
            return (dollars / days);
        }

        private static void ReadStudentsName(string [] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Enter a name to the position " + (i + 1) + ":");
                stringArray[i] = Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            //Passing value type by reference
            Console.WriteLine("**** Passing value type by reference ****\n\n");

            int totalDollars    = 100;
            int leftoverChange  = 0;
            int perDiem         = 0;
            int numberOfDays    = 5;

            Console.WriteLine("You have ${0}", totalDollars);

            perDiem = SpendingCalculator.CalculatePerDiem(totalDollars, ref leftoverChange);
            Console.WriteLine("With {0}, your per diem is {1} over {2} days with ${3} left.\n\n", totalDollars, perDiem, numberOfDays, leftoverChange);

            Console.WriteLine("How many days is your trip");
            numberOfDays = Convert.ToInt32(Console.ReadLine());

            perDiem = SpendingCalculator.CalculatePerDiem(totalDollars, ref leftoverChange, numberOfDays);
            Console.WriteLine("With {0}, your per diem is {1} over {2} days with ${3} left.\n\n", totalDollars, perDiem, numberOfDays, leftoverChange);


            //Passing value type by reference
            Console.WriteLine("**** Passing reference type by value ****\n\n");

            string[] nameArray = new string[5];
            SpendingCalculator.ReadStudentsName(nameArray);

            Console.WriteLine("\n\nThe contents of nameArray are:");
            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine(nameArray[i]);
            }

            Console.ReadLine();

        }
    }
}
