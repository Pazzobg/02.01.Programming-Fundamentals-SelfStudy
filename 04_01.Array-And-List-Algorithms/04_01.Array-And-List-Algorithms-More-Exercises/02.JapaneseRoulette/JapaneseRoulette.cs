namespace _02.JapaneseRoulette
{
    using System;
    using System.Collections.Generic;

    public class JapaneseRoulette
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var cylinder = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                cylinder.Add(input[i]);
            }

            string[] commands = Console.ReadLine().Split(' ');
            var playerMoves = new List<string>();
            for (int i = 0; i < commands.Length; i++)
            {
                playerMoves.Add(commands[i]);
            }

            int currentPlayer = 0;
            var bulletPosition = cylinder.IndexOf("1");
            bool playerShot = false;

            for (int i = 0; i < playerMoves.Count; i++)
            {
                currentPlayer = i % 6;

                string[] currentMove = playerMoves[currentPlayer].Split(',');

                bulletPosition = SpinTheCylinder(currentMove, bulletPosition);

                if (bulletPosition == 2)
                {
                    playerShot = true;
                    break;
                }

                bulletPosition = (bulletPosition + 1) % 6;
            }

            if (playerShot)
            {
                Console.WriteLine($"Game over! Player {currentPlayer} is dead.");
            }
            else
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        public static int SpinTheCylinder(string[] currentMove, int bulletPosition)
        {
            int spinValue = int.Parse(currentMove[0]);
            string spinDirection = currentMove[1];

            switch (spinDirection)
            {
                case "Right":
                    bulletPosition = (bulletPosition + spinValue) % 6;
                    break;

                case "Left":
                    if (bulletPosition - spinValue >= 0)
                    {
                        bulletPosition -= spinValue;
                    }
                    else
                    {
                        bulletPosition = 6 - (Math.Abs(bulletPosition - spinValue) % 6);
                    }
                    break;
            }

            return bulletPosition;
        }
    }
}
