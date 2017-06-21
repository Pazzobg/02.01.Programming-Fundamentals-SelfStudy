namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;

    public class Exercises
    {
        public static void Main()
        {
            var exerciseList = new List<Exercise>();

            string[] input = Console.ReadLine()
                .Split(" ->,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "go")
            {
                string currentTopic = input[0];
                string currentCourse = input[1];
                string judgeLink = input[2];
                var currentProblemsList = new List<string>();

                for (int i = 3; i < input.Length; i++)
                {
                    currentProblemsList.Add(input[i]);
                }

                var currentExercise = new Exercise
                {
                    Topic = currentTopic,
                    CourseName = currentCourse,
                    JudgeContestLink = judgeLink,
                    Problems = new List<string>()
                };

                currentExercise.Problems.AddRange(currentProblemsList);

                exerciseList.Add(currentExercise);

                input = Console.ReadLine().Split(" ->,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var exercise in exerciseList)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int numbering = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{numbering}. {problem}");
                    numbering++;
                }
            }
        }
    }
}