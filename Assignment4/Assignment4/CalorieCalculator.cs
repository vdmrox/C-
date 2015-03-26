using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class CalorieCalculator
    {
        const double CALORIE_COEFFICIENT = 0.167;
        const double POUNDKG_COEFFICIENT = 0.453592;

        private static double PoundsToKilos(double pounds)
        {
            return(pounds * POUNDKG_COEFFICIENT);
        }

        private static double CaloriesSpentRunning(double kilos, double minutes)
        {
            return(kilos * minutes * CALORIE_COEFFICIENT);
        }
        
        public static int ReadInteger(string displayString){
            
            int numberOfErrors = 0;
            int number = 0;
            bool repeatInput = false;

            do
            {
                try
                {
                    Console.Write(displayString);
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException){
                    if (numberOfErrors > 2)
                    {
                        Console.Write("There's a problem entering data. Press any key to exit the program.");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }
                    Console.Write("Input must be numeric!\n\n");
                    repeatInput = true;
                    numberOfErrors++;
                }

                catch(OverflowException){
                   if(numberOfErrors < 3)
                   {
                       Console.Write("You're having problems entering data. Press a key to exit the program.");
                       Console.ReadLine();
                       System.Environment.Exit(0);
                   }
                   Console.Write("This number is too big!\n\n");
                   repeatInput = true;
                   numberOfErrors++;
                }

            } while (repeatInput == true);

            return number;
        }

        static void Main(string[] args)
        {
            double weight;
            double minutes;
            double seconds;
            double totalTime;
            double kilos;

            Console.WriteLine("Calories Calculator");
            weight = CalorieCalculator.ReadInteger("\nEnter runner weight <libs>: ");
            minutes = CalorieCalculator.ReadInteger("\nEnter minutes running: ");
            seconds = CalorieCalculator.ReadInteger("\nEnter seconds running: ");

            totalTime = minutes + (seconds / 60);
            kilos = CalorieCalculator.PoundsToKilos(weight);

            Console.WriteLine("\nIf you run {0} minutes and {1} at 6mph", minutes, seconds);
            Console.WriteLine("the calories burned are approximately {0:N2}.", CalorieCalculator.CaloriesSpentRunning(kilos, totalTime));
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
