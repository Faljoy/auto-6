using System;
using System.Collections.Generic;
using System.Text;

namespace TT
{
    class Menue
    {
        public string NumOfEducationMenue()
        {
            Console.WriteLine("Chose a Menue:");
            Console.WriteLine("1 - Add Scores.\n" +
                "2 - Show scores a education.\n" +
                "3 - Show All.");
            return Console.ReadLine();
        }

        public string NumOfStartMenue()
        {
            Console.WriteLine("Chose a menue?");
            Console.WriteLine("1 - Add scores in a education.\n" +
                "2 - Show all education.");
            return Console.ReadLine();
        }

        public void ShowInvalidMenuePoinText()
        {
            Console.WriteLine("|False, input try|");
        }

        public int ChoseEducationOfMenue(List<Score> NameOfEducationInClass)
        {
            int number;
            string rezultNumber;
            bool check = true;
            do
            {
                int index = 1;
                foreach (Score value in NameOfEducationInClass)
                {
                    Console.WriteLine($"{index++} - {value.EducationName} ");
                }
                Console.Write("Chose Value: ");
                rezultNumber = Console.ReadLine();
                check = int.TryParse(rezultNumber, out number);
                if (!check || number < 1 || number > 5) Console.WriteLine("False");
            } while (!check || number < 1 || number > 5);
            return number - 1;
        }

        public string Space(int countOfNumber,int numberStartSpace)
        {
            string space = "";
            for (int i = 0; i < numberStartSpace - countOfNumber; i++)
            {
                space += " ";
            }
            return space;
        }
    }
}
