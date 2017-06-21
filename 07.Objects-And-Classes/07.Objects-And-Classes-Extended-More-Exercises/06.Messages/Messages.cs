namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Messages
    {
        public static void Main()
        {
            var users = new Dictionary<string, User>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "exit")
            {
                if (input[0] == "register")
                {
                    string name = input[1];

                    var currentUser = new User
                    {
                        Username = name,
                        ReceivedMessages = new List<Message>()
                    };

                    if (!users.ContainsKey(name))
                    {
                        users[name] = currentUser;
                    }
                }
                else
                {
                    string sender = input[0];
                    string recipient = input[2];
                    string content = input[3];

                    if (!users.ContainsKey(sender) || (!users.ContainsKey(recipient)))
                    {
                        input = Console.ReadLine().Split(' ');
                        continue;
                    }

                    var currentMessage = new Message
                    {
                        Content = content,
                        Sender = new User
                        {
                            Username = sender
                        }
                    };

                    users[recipient].ReceivedMessages.Add(currentMessage);
                }

                input = Console.ReadLine().Split(' ');
            }

            string[] contactsToDisplayMessages = Console.ReadLine().Split(' ');
            string firstUser = contactsToDisplayMessages[0];
            string secondUser = contactsToDisplayMessages[1];

            var messagesToFirstUser = new List<Message>();
            var messagesToSecondUser = new List<Message>();

            bool correspondencePresent = false;

            foreach (var kvp in users.Where(x => x.Key == firstUser))
            {
                string name = kvp.Key;
                var currentFirstUser = kvp.Value;

                foreach (var message in currentFirstUser.ReceivedMessages
                    .Where(x => x.Sender.Username == secondUser))
                {
                    messagesToFirstUser.Add(message);
                    correspondencePresent = true;
                }
            }

            foreach (var kvp in users.Where(x => x.Key == secondUser))
            {
                string name = kvp.Key;
                var currentSecondUser = kvp.Value;

                foreach (var message in currentSecondUser.ReceivedMessages
                    .Where(x => x.Sender.Username == firstUser))
                {
                    messagesToSecondUser.Add(message);
                    correspondencePresent = true;
                }
            }

            if (!correspondencePresent)
            {
                Console.WriteLine("No messages");
                return;
            }

            int shorterMsgListCount = Math.Min(messagesToFirstUser.Count, messagesToSecondUser.Count);

            for (int i = 0; i < shorterMsgListCount; i++)
            {
                Console.WriteLine($"{firstUser}: {messagesToSecondUser[i].Content}");
                Console.WriteLine($"{messagesToFirstUser[i].Content} :{secondUser}");
            }

            if (messagesToFirstUser.Count > shorterMsgListCount) // first user has remaining messages
            {
                for (int i = shorterMsgListCount; i < messagesToFirstUser.Count; i++)
                {
                    Console.WriteLine($"{messagesToFirstUser[i].Content} :{secondUser}");
                }
            }
            else if (messagesToSecondUser.Count > shorterMsgListCount) // second user has remaining messages
            {
                for (int i = shorterMsgListCount; i < messagesToSecondUser.Count; i++)
                {
                    Console.WriteLine($"{firstUser}: {messagesToSecondUser[i].Content}"); //TAKA ILI OBYRNATO????
                }
            }
        }
    }
}
