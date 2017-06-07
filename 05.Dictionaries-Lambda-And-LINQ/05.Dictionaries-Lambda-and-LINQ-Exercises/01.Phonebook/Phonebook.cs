namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "END")
            {
                string command = input[0];
                string name = input[1];

                if (command == "A")
                {
                    string number = input[2];

                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = string.Empty;
                    }

                    phoneBook[name] = number;
                }
                else if (command == "S")
                {
                    if (!phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        string numberOfFoundContact = phoneBook[name];
                        Console.WriteLine($"{name} -> {numberOfFoundContact}");
                    }
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
