namespace _02.JsonStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JsonStringify
    {
        public static void Main()
        {
            var students = new List<Student>();
            
            string inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                int firstSpaceIndex = inputLine.IndexOf(' ');
                string name = inputLine.Substring(0, firstSpaceIndex);
                string rest = inputLine.Substring(firstSpaceIndex);
                var inputParams = rest.Trim().Split(":->, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int age = inputParams[0];
                inputParams.RemoveAt(0);

                var student = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = new List<int>()
                };

                student.Grades.AddRange(inputParams);

                students.Add(student);

                inputLine = Console.ReadLine();
            }

            var output = new List<string>();

            foreach (var student in students)
            {
                output.Add("{" + $"name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]" + "}");
            }

            Console.WriteLine($"[{string.Join(",", output)}]");
        }
    }
}
