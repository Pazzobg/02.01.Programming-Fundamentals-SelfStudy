namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int days = int.Parse(Console.ReadLine());

            while (grapes.Count > days)
            {
                for (int singleDay = 0; singleDay < days; singleDay++)
                {
                    for (int normalGrowth = 0; normalGrowth < grapes.Count; normalGrowth++)
                    {
                        if (grapes[normalGrowth] > 0)
                        {
                            grapes[normalGrowth]++;
                        }
                    }

                    CheckForGreater(grapes);
                }

                RemoveWeakGrapes(grapes, days);
            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        public static void CheckForGreater(List<int> grapes)
        {
            for (int greater = 1; greater < grapes.Count - 1; greater++)
            {
                var prev = greater - 1;
                var next = greater + 1;
                bool isGreaterGrape = (grapes[greater] > grapes[prev]) && (grapes[greater] > grapes[next]);

                if (isGreaterGrape)
                {
                    grapes[greater]--;

                    if (grapes[prev] > 0)
                    {
                        grapes[greater]++;
                        grapes[prev] = Math.Max(grapes[prev] - 2, 0);
                    }

                    if (grapes[next] > 0)
                    {
                        grapes[greater]++;
                        grapes[next] = Math.Max(grapes[next] - 2, 0);
                    }
                }
            }
        }

        public static void RemoveWeakGrapes(List<int> grapes, int days)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= days)
                {
                    grapes.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
