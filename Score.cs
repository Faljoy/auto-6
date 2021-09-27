using System;
using System.Collections.Generic;
using System.Text;

namespace TT
{
    class Score
    {
        public string EducationName;
        public List<int> ScoreOfEducation;
        public static int min = 100;

        public Score(string EducationName)
        {
            this.EducationName = EducationName;
            ScoreOfEducation = new List<int>();
        }

        public int Scores()
        {
            int number;
            string rezultNumber;
            bool check = true;
            do
            {
                Console.WriteLine("Input Scores 1 - 100:");
                rezultNumber = Console.ReadLine();
                check = int.TryParse(rezultNumber, out number);
                if (!check || number < 1 || number > 100) Console.WriteLine("False");
            } while (!check || number < 1 || number > 100);
            return number;
        }

        public void AddScore(int Scores)
        {
            ScoreOfEducation.Add(Scores);
        }

        public void Show()
        {
            int max = 0;
            int count = 0;
            double sum = 0.0;
            foreach (int num in ScoreOfEducation)
            {
                if (num > max) max = num;
                if (min > num) min = num;
                sum += num;
                count++;
                Console.Write($"{num} ");
            }
            if (count > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Max - {max}, Min - {min}, Average - {sum / count}");
            }
            else Console.WriteLine("Information is absent");
        }

        public int Count()
        {
            int count = 0;
            foreach (int num in ScoreOfEducation)
            {
                count++;
            }
            return count;
        }

        public int Max()
        {
            int max = 0;
            foreach (int num in ScoreOfEducation)
            {
                if (num > max) max = num;
            }
            return max;
        }

        public int Min()
        {
            foreach (int num in ScoreOfEducation)
            {
                if (num < min) min = num;
            }
            return min;
        }

        public double Average()
        {
            double avg;
            int count = 0;
            double sum = 0;
            foreach (int num in ScoreOfEducation)
            {
                sum += num;
                count++;
            }
            avg = Math.Round(sum /(double)count, 2);
            return avg;
        }
    }
}
