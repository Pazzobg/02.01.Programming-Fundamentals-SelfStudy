namespace _18.SequenceOfCommands
{
    using System;
    using System.Linq;

    public class SequenceOfCommands
    {
        private const char ArgumentsDelimiter = ' ';

        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] arrayToChange = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "stop")
            {
                string[] lineSplitted = command.Split(ArgumentsDelimiter);

                if (lineSplitted[0].Equals("add")
                    || lineSplitted[0].Equals("subtract")
                    || lineSplitted[0].Equals("multiply"))
                {
                    int positionOfTheIndex = int.Parse(lineSplitted[1]);
                    int valueToBeChangedWith = int.Parse(lineSplitted[2]);

                    PerformAction(arrayToChange, lineSplitted[0], positionOfTheIndex, valueToBeChangedWith);
                }
                else if (lineSplitted[0].Equals("lshift"))
                {
                    ArrayShiftLeft(arrayToChange);
                }
                else
                {
                    ArrayShiftRight(arrayToChange);
                }

                PrintArray(arrayToChange);

                command = Console.ReadLine();
            }
        }

        static void PerformAction(int[] arrayToBeChanged, string action, int position, int value)
        {

            switch (action)
            {
                case "multiply":
                    arrayToBeChanged[position - 1] *= value;
                    break;
                case "add":
                    arrayToBeChanged[position - 1] += value;
                    break;
                case "subtract":
                    arrayToBeChanged[position - 1] -= value;
                    break;
            }
        }

        private static void ArrayShiftRight(int[] array)
        {
            int num = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = num;
        }

        private static void ArrayShiftLeft(int[] array)
        {
            int num = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = num;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.WriteLine(array[i] + " ");
                    break;
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}
