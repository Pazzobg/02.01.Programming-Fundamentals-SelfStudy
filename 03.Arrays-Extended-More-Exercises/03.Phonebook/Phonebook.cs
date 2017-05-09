namespace _03.Phonebook
{
    using System;

    public class Phonebook
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string inputName = Console.ReadLine();

            while (inputName != "done")
            {
                LookUpTelephoneNumber(phoneNumbers, names, inputName);

                inputName = Console.ReadLine();
            }
        }

        public static void LookUpTelephoneNumber(string[] phones, string[] names, string input)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (input == names[i])
                {
                    Console.WriteLine($"{names[i]} -> {phones[i]}");
                }
            }
        }
    }
}
