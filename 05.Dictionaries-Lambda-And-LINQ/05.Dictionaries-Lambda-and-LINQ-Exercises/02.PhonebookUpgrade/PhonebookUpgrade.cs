namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var phoneBook = new SortedDictionary<string, string>();     // Second solution using LINQ.Orderby:
                                                                        // use a regular Dictionary<> for phonebook
            string[] input = Console.ReadLine().Split(' ');             // scroll down...

            while (input[0] != "END")
            {
                string command = input[0];

                if (command == "A")
                {
                    string number = input[2];
                    string name = input[1];

                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = string.Empty;
                    }

                    phoneBook[name] = number;
                }
                else if (command == "S")
                {
                    string name = input[1];

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
                else if (command == "ListAll")
                {
                    //var sortedPhonebook = phoneBook                       Create a new Dictionary, ordered by 
                    //    .OrderBy(x => x.Key)                              the Keys of the first one
                    //    .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var kvp in phoneBook)                          // kvp in sortedPhonebook
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
