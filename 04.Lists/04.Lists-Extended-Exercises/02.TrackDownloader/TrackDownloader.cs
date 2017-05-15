namespace _02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine().Split(' ').ToList();
            var outputList = new List<string>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                bool found = false;

                for (int i = 0; i < blackList.Count; i++)
                {
                    string currentBlackListEntry = blackList[i];

                    if (command.Contains(currentBlackListEntry))
                    {
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    outputList.Add(command);
                }

                command = Console.ReadLine();
            }

            outputList.Sort();
            outputList.ForEach(Console.WriteLine);
        }
    }
}
