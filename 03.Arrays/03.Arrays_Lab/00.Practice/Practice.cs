namespace _00.Practice
{
    using System;
    using System.Linq;

    public class Practice
    {
        public static void Main()
        {
            string text = "1, 2, 3, 4, 5 ";

            var result = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int a = result[2] + result[3];
            Console.WriteLine(a);
        }
    }
}
