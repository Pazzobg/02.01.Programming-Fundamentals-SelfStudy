namespace _01.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var namesList = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!namesList.ContainsKey(name))
                {
                    namesList[name] = new List<double>();
                }

                namesList[name].Add(grade);
            }

            foreach (var kvPair in namesList)
            {
                string studentName = kvPair.Key;
                var studentGrades = kvPair.Value;
                var average = GetAverage(studentGrades);

                Console.Write($"{studentName} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {average:f2})");
            }
        }

        public static double GetAverage(List<double> studentGrades)
        {
            double sum = 0;

            for (int i = 0; i < studentGrades.Count; i++)
            {
                sum += studentGrades[i];
            }

            return sum / studentGrades.Count;
        }
    }
}