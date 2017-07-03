﻿namespace _03.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pyramidic
    {
        public static void Main()
        {
            var pyramids = new List<string>();
            int n = int.Parse(Console.ReadLine());

            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentChar = currentLine[j];
                    int layer = 1;
                    string currentPyramid = string.Empty;

                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(currentChar, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }
            }

            pyramids = pyramids.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(pyramids[0]);
        }
    }
}
