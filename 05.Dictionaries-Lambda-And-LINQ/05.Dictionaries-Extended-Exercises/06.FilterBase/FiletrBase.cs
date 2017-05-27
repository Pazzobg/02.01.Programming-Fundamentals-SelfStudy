namespace _06.FilterBase
{
    using System;
    using System.Collections.Generic;

    public class FiletrBase
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var dictAge = new Dictionary<string, int>();
            var dictSalary = new Dictionary<string, double>();
            var dictPosition = new Dictionary<string, string>();

            while (input[0] != "filter")
            {
                string name = input[0];
                string rightStringValue = input[1];

                int currentIntValule = 0;
                bool parsedAsInt = int.TryParse(rightStringValue, out currentIntValule);

                double currentDblValue = 0;
                bool parsedAsDouble = double.TryParse(rightStringValue, out currentDblValue);

                if (parsedAsInt)
                {
                    dictAge.Add(name, currentIntValule);
                }
                else if (parsedAsDouble)
                {
                    dictSalary.Add(name, currentDblValue);
                }
                else
                {
                    dictPosition.Add(name, rightStringValue);
                }

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string sortingCommand = Console.ReadLine();

            switch (sortingCommand)
            {
                case "Age":
                    foreach (var kvp in dictAge)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Age: {kvp.Value}");
                        Console.WriteLine("====================");
                    }
                    break;

                case "Salary":
                    foreach (var kvp in dictSalary)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Salary: {kvp.Value:f2}");
                        Console.WriteLine("====================");
                    }
                    break;

                case "Position":
                    foreach (var kvp in dictPosition)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
            }
        }
    }
}
