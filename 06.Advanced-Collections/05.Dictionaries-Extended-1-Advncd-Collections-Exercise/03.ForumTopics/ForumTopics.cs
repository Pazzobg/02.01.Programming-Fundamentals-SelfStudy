namespace _03.ForumTopics
{
    using System;
    using System.Collections.Generic;

    public class ForumTopics
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var topicCollection = new Dictionary<string, HashSet<string>>();

            while (input[0] != "filter")
            {
                string topic = input[0];

                if (!topicCollection.ContainsKey(topic))
                {
                    topicCollection[topic] = new HashSet<string>();
                }

                for (int i = 1; i <= input.Length - 1; i++)
                {
                    topicCollection[topic].Add(input[i]);
                }

                input = Console.ReadLine().Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] filters = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var topic in topicCollection)
            {
                bool filterFound = true;

                string topicName = topic.Key;
                var tags = topic.Value;

                foreach (var filter in filters)
                {
                    if (!tags.Contains(filter))
                    {
                        filterFound = false;
                        break;
                    }
                }

                if (filterFound)
                {
                    Console.WriteLine($"{topicName} | #{string.Join(", #", tags)}");
                }
            }
        }
    }
}
