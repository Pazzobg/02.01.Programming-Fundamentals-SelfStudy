namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var playersDict = new Dictionary<string, HashSet<string>>();

            string[] input = Console.ReadLine().Split(':');

            while (input[0] != "JOKER")
            {
                string nameOfPlayer = input[0];
                string currentAllCards = input[1];

                if (!playersDict.ContainsKey(nameOfPlayer))
                {
                    playersDict[nameOfPlayer] = new HashSet<string>();
                }

                string[] currentTrick = currentAllCards.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in currentTrick)
                {
                    playersDict[nameOfPlayer].Add(card);
                }

                input = Console.ReadLine().Split(':');
            }

            foreach (var player in playersDict)
            {
                string name = player.Key;
                var cardsInHand = player.Value;

                Console.Write($"{name}: ");

                int sum = 0;

                foreach (var card in cardsInHand)
                {
                    char suite = card[card.Length - 1];
                    char power = card[card.Length - 2];

                    int multiplyer = 0;
                    multiplyer = GetSuite(suite, multiplyer);

                    sum = GetPower(sum, power, multiplyer);
                }

                Console.WriteLine(sum);
            }
        }

        public static int GetPower(int sum, char power, int multiplyer)
        {
            switch (power)
            {
                case '2': sum += 2 * multiplyer; break;
                case '3': sum += 3 * multiplyer; break;
                case '4': sum += 4 * multiplyer; break;
                case '5': sum += 5 * multiplyer; break;
                case '6': sum += 6 * multiplyer; break;
                case '7': sum += 7 * multiplyer; break;
                case '8': sum += 8 * multiplyer; break;
                case '9': sum += 9 * multiplyer; break;
                case '0': sum += 10 * multiplyer; break;
                case 'J': sum += 11 * multiplyer; break;
                case 'Q': sum += 12 * multiplyer; break;
                case 'K': sum += 13 * multiplyer; break;
                case 'A': sum += 14 * multiplyer; break;
            }

            return sum;
        }

        public static int GetSuite(char suite, int multiplyer)
        {
            switch (suite)
            {
                case 'S': multiplyer = 4; break;
                case 'H': multiplyer = 3; break;
                case 'D': multiplyer = 2; break;
                case 'C': multiplyer = 1; break;
            }

            return multiplyer;
        }
    }
}
