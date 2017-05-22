namespace _01.RabbitHole
{
    using System;
    using System.Collections.Generic;

    public class RabbitHole
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var commands = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                commands.Add(input[i]);
            }

            int energy = int.Parse(Console.ReadLine());
            int position = 0;
            bool savedKennedy = false;
            bool killedByBomb = false;
            int actionValue = 0;

            while (energy > 0 && !savedKennedy)
            {
                string[] currCommand = commands[position].Split('|');

                string currentAction = currCommand[0];
                if (currCommand.Length == 2)
                {
                    actionValue = int.Parse(currCommand[1]);
                }

                switch (currentAction)
                {
                    case "Left":
                        position = Math.Abs(position - actionValue) % commands.Count;
                        energy -= actionValue;
                        break;
                    case "Right":
                        position = (position + actionValue) % commands.Count;
                        energy -= actionValue;
                        break;
                    case "Bomb":
                        commands.RemoveAt(position);
                        energy -= actionValue;

                        if (energy <= 0)
                        {
                            killedByBomb = true;
                        }

                        position = 0;
                        break;
                    case "RabbitHole":
                        Console.WriteLine("You have 5 years to save Kennedy!");
                        savedKennedy = true;
                        break;
                }

                if (commands[commands.Count - 1] != "RabbitHole")
                {
                    commands.RemoveAt(commands.Count - 1);
                }

                commands.Add($"Bomb|{energy}");
            }

            if (killedByBomb == true && !savedKennedy)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (!killedByBomb && !savedKennedy)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
