namespace _01.DayOfWeek
{
    using System; 

    public class DayOfWeek
    {
        public static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(days[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
