namespace _03.JsonParse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JsonParse
    {
        public static void Main()
        {
            var studentsList = new List<Student>();

            string[] inputAllStudents = Console.ReadLine().Trim('[', ']').Split("}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var student in inputAllStudents)
            {
                var tokens = student.Split(':');
                string nameToken = tokens[1];
                string ageToken = tokens[2];
                string gradesToken = tokens[3];

                // extracting Name
                string name = nameToken.Substring(1, nameToken.Length - 6);

                // extracting Age
                int ageStr = int.Parse(ageToken.Substring(0, ageToken.Length - 7));

                // extracting Grades
                var grades = gradesToken
                    .Trim('[', ']')
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var currentStudent = new Student
                {
                    Name = name,
                    Age = ageStr,
                    Grades = new List<int>()
                };

                foreach (var grade in grades)
                {
                    currentStudent.Grades.Add(grade);
                }

                studentsList.Add(currentStudent);
            }

            foreach (var student in studentsList)
            {
                string name = student.Name;
                int age = student.Age;
                int[] grades = student.Grades.ToArray();

                Console.Write($"{name} : {age} -> ");
                Console.WriteLine(grades.Length > 0 ? string.Join(", ", grades) : "None");
            }
        }
    }
}
