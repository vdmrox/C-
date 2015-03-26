// Assignment 3, Vinicius L. de Moraes, CIS 345, Tuesday 3:00 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class GradeSystem
    {
        private static void PopulateNameArray(string[] names)
        {
            int arraylength = names.Length;

            Console.WriteLine("******************************");
            Console.WriteLine("Enter the name of {0} students", arraylength);
            Console.WriteLine("******************************\n");

            for (int i = 0; i < arraylength; i++)
            {
                names[i] = Console.ReadLine();
            }
        }

        private static void PopulateScoreArray(string[] names, int[] scores)
        {
            Console.WriteLine("\n*********************************");
            Console.WriteLine("Enter scores. One score per line.");
            Console.WriteLine("*********************************\n");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Enter score for {0}: ", names[i]);
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static int FindStudentPosition(string name, string[] stringArray)
        {
            int pos = -1;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (name == stringArray[i]){
                    pos = i;
                    break;
                }
            }
            return (pos);
        }

        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] scores = new int [5];
            string name;
            int studentPosition;

            Console.WriteLine("                     Student Grade System                      \n");
            Console.WriteLine("This program will store students grade and look them up for you\n");

            GradeSystem.PopulateNameArray(names);
            GradeSystem.PopulateScoreArray(names, scores);
            Console.Clear();

            Console.Write("Enter the name of the student whose console you would like to find: ");
            name = Console.ReadLine();
            studentPosition = GradeSystem.FindStudentPosition(name, names);

            if(studentPosition == -1){
                Console.WriteLine("\nI'm sorry. There's no student by that name.");
            }
            else
            {
                Console.WriteLine("\nThe score for {0} is {1}.", names[studentPosition], scores[studentPosition]);
            }
            Console.WriteLine("\nPress 'Enter' key to exit.");
            Console.ReadLine();


        }
    }
}
