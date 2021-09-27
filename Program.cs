using System;
using System.Collections.Generic;

namespace TT
{
    class Program
    {
        static void Main(string[] args)
        {
            Menue menue = new Menue();
            List<Score> listOfEducation = new List<Score>(){new Score("C#"), new Score("JAVA"), new Score("Java Script"),
                new Score("Python"), new Score("C++")};

            do
            {
                string choseOfMenue = menue.NumOfStartMenue();
                Console.Clear();
                switch (choseOfMenue)
                {
                    case "1":
                        int ind = menue.ChoseEducationOfMenue(listOfEducation);
                        do
                        {
                            string chose = menue.NumOfEducationMenue();
                            Console.Clear();
                            switch (chose)
                            {
                                case "1":
                                    int score = listOfEducation[ind].Scores();
                                    listOfEducation[ind].AddScore(score);
                                    break;

                                case "2":
                                    Console.WriteLine(listOfEducation[ind].EducationName);
                                    listOfEducation[ind].Show();
                                    break;

                                case "3":
                                    for (int i = 0; i < listOfEducation.Count; i++)
                                    {
                                        Console.WriteLine(listOfEducation[i].EducationName);
                                        listOfEducation[i].Show();
                                        Console.WriteLine();
                                    }
                                    break;

                                default:
                                    Console.WriteLine(" ----------------");
                                    menue.ShowInvalidMenuePoinText();
                                    Console.WriteLine(" ----------------");
                                    break;
                            }

                            int countOfSymbolInEducationName = listOfEducation[ind].EducationName.Length;
                            Console.WriteLine(" --------------------------------------------------");
                            Console.WriteLine($"|Press any Key for continue work with a {listOfEducation[ind].EducationName}{menue.Space(countOfSymbolInEducationName, 11)}|\n" +
                                $"|Esc - for exit in start menue\t\t\t   |");
                            Console.WriteLine(" --------------------------------------------------");

                        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                        break;

                    case "2":
                        int max = 0;
                        int min = 100;
                        double avg = 0;
                        int count = 0;
                        for (int i = 0; i < listOfEducation.Count; i++)
                        {
                            if (listOfEducation[i].Count() > 0)
                            {
                                if (listOfEducation[i].Max() > max) max = listOfEducation[i].Max();
                                if (listOfEducation[i].Min() < min) min = listOfEducation[i].Min();
                                avg += listOfEducation[i].Average();
                                count++;
                            }
                        }
                        double averageOfRezultAllEducation = Math.Round(avg / count, 2);

                        if (count > 0)
                        {
                            Console.WriteLine(" ---------------------------------------");
                            Console.WriteLine($"|Maximum score of all education - {max},{menue.Space(max.ToString().Length, 5)}|\n" +
                                $"|Minimum score of all education - {min},{menue.Space(min.ToString().Length, 5)}|\n" +
                                $"|Average score of all education - {averageOfRezultAllEducation}." +
                                $"{menue.Space(averageOfRezultAllEducation.ToString().Length, 5)}|");
                            Console.WriteLine(" ---------------------------------------");
                        }
                        else Console.WriteLine("Information is absent. Please add information");
                        break;

                    default:
                        Console.WriteLine(" ----------------");
                        menue.ShowInvalidMenuePoinText();
                        Console.WriteLine(" ----------------");
                        break;
                }

                Console.WriteLine(" -------------------------------");
                Console.WriteLine("|Press any Key for continue\t|\n|Esc - for exit\t\t\t|");
                Console.WriteLine(" -------------------------------");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
