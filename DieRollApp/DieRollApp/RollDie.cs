// In-Class 2, Vinicius L. de Moraes, CIS 345, T Th 3:00 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollApp
{
    class RollDie
    {
        static string NumberToText(int dieValue){
            string numberText = "";

            switch (dieValue)
            {
                case 1:
                    numberText = "ONE";
                    break;

                case 2:
                    numberText = "TWO";
                    break;

                case 3:
                    numberText = "THREE";
                    break;

                case 4:
                    numberText = "FOUR";
                    break;

                case 5:
                    numberText = "FIVE";
                    break;

                case 6:
                    numberText = "SIX";
                    break;

                default:
                    numberText = "NULL";
                    break;

            }

            return (numberText);
        }

        static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int dieFace = rnd.Next(1, 7);
            return (dieFace);
        }

        static void Main(string[] args)
        {
            int dieValue;
            string faceText;
            string watch = "y";

            Console.Write("Press Enter to roll a dice.");
            Console.ReadLine();

            do
            {
                dieValue = RollDie.GenerateRandomNumber();
                faceText = RollDie.NumberToText(dieValue);
                Console.WriteLine("The number you've got is {0}!", faceText);
                Console.WriteLine("Continue? [y] yes, [n] no");
                watch = Console.ReadLine();
            } while (watch == "y");

            Console.WriteLine("End of program. Press any key");
            Console.ReadLine();
        }
    }
}
