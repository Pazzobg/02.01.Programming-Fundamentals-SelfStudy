namespace _03.JsonParse_2
{
    using System;
    using System.Collections.Generic;

    public class JsonParse2
    {
        public static void Main()
        {
            var studentsList = new List<Student>();

            string[] inputAllStudents = Console.ReadLine().Trim('[', ']')
                .Split("}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

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
                var grades = gradesToken.Trim('[', ']');

                var currentStudent = new Student
                {
                    Name = name,
                    Age = ageStr,
                    Grades = grades
                };

                studentsList.Add(currentStudent);
            }

            foreach (var student in studentsList)
            {
                string name = student.Name;
                int age = student.Age;
                string grades = student.Grades;

                Console.Write($"{name} : {age} -> ");
                Console.WriteLine(grades.Length > 0 ? grades : "None");
            }
        }
    }
}
