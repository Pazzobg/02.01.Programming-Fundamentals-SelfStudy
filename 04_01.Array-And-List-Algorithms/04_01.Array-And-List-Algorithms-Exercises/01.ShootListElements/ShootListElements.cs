namespace _01.ShootListElements
{
    using System;
    using System.Collections.Generic;

    public class ShootListElements
    {
        public static int Last = 0;

        public static void Main()
        {
            var numsList = new List<int>();
            string command = Console.ReadLine();

            while (command != "stop")
            {
                if (command == "bang")
                {
                    switch (numsList.Count)
                    {
                        case 0:
                            Console.WriteLine($"nobody left to shoot! last one was {Last}");
                            Environment.Exit(0);
                            break;

                        case 1:
                            Console.WriteLine($"shot {numsList[0]}");
                            Last = numsList[0];
                            numsList.RemoveAt(0);
                            break;

                        default:
                            numsList = BangHeard(numsList);
                            break;
                    }
                }
                else
                {
                    int currentNum = int.Parse(command);

                    numsList = AddNewNumber(numsList, currentNum);
                }

                command = Console.ReadLine();
            }

            switch (numsList.Count)
            {
                case 0: Console.WriteLine($"you shot them all. last one was {Last}"); break;

                default: Console.WriteLine($"survivors: {string.Join(" ", numsList)}"); break;
            }
        }

        public static List<int> BangHeard(List<int> numsList)
        {
            double sum = 0;

            for (int i = 0; i < numsList.Count; i++) // Finding the sum of all elements in order to find the average
            {                                        // of the collection
                sum += numsList[i];
            }

            double average = sum / numsList.Count;

            for (int i = 0; i < numsList.Count; i++) // "Shooting" the first element with lower then the avg. value
            {
                if (numsList[i] < average)
                {
                    Console.WriteLine($"shot {numsList[i]}");
                    Last = numsList[i];
                    numsList.Remove(numsList[i]);
                    break;
                }
            }

            for (int i = 0; i < numsList.Count; i++) // decrementing the values of all remaining elements by one
            {
                numsList[i]--;
            }

            return numsList;
        }

        public static List<int> AddNewNumber(List<int> listSoFar, int numToBePutInFront)
        {
            listSoFar.Insert(0, numToBePutInFront);   // Adding new number to the list
            return listSoFar;
        }
    }
}
