namespace _05.BombNumbers
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombProperties = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bomb = bombProperties[0];
            int bombPower = bombProperties[1];

            int sum = 0;

            for (int positionIndex = 0; positionIndex < inputList.Count; positionIndex++)
            {
                if (inputList[positionIndex] == bomb)
                {
                    inputList.RemoveAt(positionIndex);

                    for (int blastForward = 0; blastForward < bombPower; blastForward++)
                    {
                        if (inputList.Count > positionIndex)
                        {
                            inputList.RemoveAt(positionIndex);
                        }
                        else
                        {
                            break;
                        }
                    }

                    for (int blastBackward = 0; blastBackward < bombPower; blastBackward++)
                    {
                        if (positionIndex - 1 >= 0)
                        {
                            inputList.RemoveAt(positionIndex - 1);
                            positionIndex--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    positionIndex = 0;
                }
            }

            foreach (var number in inputList)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
