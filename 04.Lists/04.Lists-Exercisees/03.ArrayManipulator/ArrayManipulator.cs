namespace _03.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        AddNumber(numbers, command);
                        break;

                    case "addMany":
                        AddManyNumbers(numbers, command);
                        break;

                    case "contains":
                        ContainsNumber(numbers, command);
                        break;

                    case "remove":
                        RemoveNumber(numbers, command);
                        break;

                    case "shift":
                        ShiftNumber(numbers, command);
                        break;

                    case "sumPairs":
                        SumNumbersPairs(numbers, command);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static void AddNumber(List<int> numbers, string[] command)
        {
            int index = int.Parse(command[1]);
            int elementAdd = int.Parse(command[2]);

            numbers.Insert(index, elementAdd);
        }

        public static void AddManyNumbers(List<int> numbers, string[] command)
        {
            int insertIndex = int.Parse(command[1]);

            var newListToInsert = new List<int>();

            for (int i = 2; i < command.Length; i++)
            {
                newListToInsert.Add(int.Parse(command[i]));
            }

            numbers.InsertRange(insertIndex, newListToInsert);
        }

        public static void ContainsNumber(List<int> numbers, string[] command)
        {
            int elementContain = int.Parse(command[1]);

            if (numbers.Contains(elementContain))
            {
                Console.WriteLine(numbers.IndexOf(elementContain));
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        public static void RemoveNumber(List<int> numbers, string[] command)
        {
            int elementRemove = int.Parse(command[1]);

            numbers.RemoveAt(elementRemove);
        }

        public static void ShiftNumber(List<int> numbers, string[] command)
        {
            int positions = int.Parse(command[1]);

            for (int i = 0; i < positions; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        public static void SumNumbersPairs(List<int> numbers, string[] command)
        {
            int j = 0;

            while (j < numbers.Count - 1)
            {
                numbers[j] += numbers[j + 1];
                numbers.RemoveAt(j + 1);

                j++;
            }
        }
    }
}
