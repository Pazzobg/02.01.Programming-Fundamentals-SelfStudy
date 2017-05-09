namespace _04.Phone
{
    using System;
    using System.Linq;

    public class Phone
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "done")
            {
                ActivatePhone(phoneNumbers, names, command);

                command = Console.ReadLine().Split(' ');
            }
        }

        public static void ActivatePhone(string[] numbers, string[] names, string[] command)
        {
            if (command[0] == "call")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (command[1] == names[i])
                    {
                        Console.WriteLine($"calling {numbers[i]}...");

                        CallDetails(numbers[i], command[0]);
                    }
                    else if (command[1] == numbers[i])
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        CallDetails(numbers[i], command[0]);
                    }
                }
            }
            else if (command[0] == "message")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (command[1] == names[i])
                    {
                        Console.WriteLine($"sending sms to {numbers[i]}...");

                        CallDetails(numbers[i], command[0]);
                    }
                    else if (command[1] == numbers[i])
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");

                        CallDetails(numbers[i], command[0]);
                    }
                }
            }
        }

        public static void CallDetails(string contactNumber, string command)
        {
            int sum = 0;
            int diff = 0;

            for (int i = 0; i < contactNumber.Length; i++)
            {
                if (contactNumber[i] >= 48 && contactNumber[i] <= 57)
                {
                    sum += int.Parse(contactNumber[i].ToString());
                    diff -= int.Parse(contactNumber[i].ToString());
                }
            }

            if (command == "call")
            {
                if (sum % 2 != 0)
                {
                    Console.WriteLine("no answer");
                }
                else
                {
                    int minutesTalk = sum / 60;
                    int secondsTalk = sum % 60;
                    Console.WriteLine($"call ended. duration: {minutesTalk:00}:{secondsTalk:00}");
                }
            }
            else if (command == "message")
            {
                if (diff % 2 != 0)
                {
                    Console.WriteLine("busy");
                }
                else
                {
                    Console.WriteLine("meet me there");
                }
            }
        }
    }
}
