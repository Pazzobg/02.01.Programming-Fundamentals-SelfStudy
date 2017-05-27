namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower()
                .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            var output = text.Where(t => t.Length < 5)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
