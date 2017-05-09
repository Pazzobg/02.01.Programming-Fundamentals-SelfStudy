namespace _07.ResizableArray
{
    using System;

    public class ResizableArray
    {
        public static void Main()
        {
            string[] numbers = new string[4];
            string[] commands = Console.ReadLine().Split(' ');

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "push": numbers = PushMethod(commands[1], numbers); break;
                    case "pop": PopMethod(numbers); break;
                    case "removeAt": RemoveAtMethod(commands[1], numbers); break;
                    case "clear": ClearMethod(numbers); break;
                }

                commands = Console.ReadLine().Split(' ');
            }

            if (numbers[0] == null)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        public static string[] PushMethod(string digit, string[] numbers)
        {
            for (int cycle = 0; cycle <= numbers.Length; cycle++)
            {
                if (cycle == numbers.Length)
                {
                    numbers = ExtendArray(numbers);
                }

                if (numbers[cycle] == null)
                {
                    numbers[cycle] = digit;
                    break;
                }
            }

            return numbers;
        }

        public static string[] ExtendArray(string[] numbers)
        {
            string[] longerNumbers = new string[numbers.Length * 2];
            for (int cycle = 0; cycle < numbers.Length; cycle++)
            {
                longerNumbers[cycle] = numbers[cycle];
            }

            return longerNumbers;
        }

        public static void PopMethod(string[] numbers)
        {
            for (int cycle = numbers.Length - 1; cycle >= 0; cycle--)
            {
                if (numbers[cycle] != null)
                {
                    numbers[cycle] = null;
                    break;
                }
            }
        }

        public static void RemoveAtMethod(string commands, string[] numbers)
        {
            int digit = int.Parse(commands);
            numbers[digit] = null;
            for (int cycle = digit; cycle < numbers.Length - 1; cycle++)
            {
                numbers[cycle] = numbers[cycle + 1];
                if (numbers[cycle + 1] == null)
                {
                    break;
                }
            }

            numbers[numbers.Length - 1] = null;
        }

        public static void ClearMethod(string[] numbers)
        {
            for (int cycle = 0; cycle < numbers.Length; cycle++)
            {
                numbers[cycle] = null;
            }
        }
    }
}
