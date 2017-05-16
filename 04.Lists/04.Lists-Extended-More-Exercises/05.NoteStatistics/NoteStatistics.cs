namespace _05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var notesList = new List<string>();
            var naturalsList = new List<string>();
            var sharpsList = new List<string>();
            double sumNaturals = 0;
            double sumSharps = 0;

            for (int index = 0; index < inputList.Count; index++)
            {
                string currentNote = NoteFinder(inputList[index]);

                notesList.Add(currentNote);

                if (currentNote.Contains("#"))
                {
                    sumSharps += inputList[index];
                    sharpsList.Add(currentNote);
                }
                else
                {
                    sumNaturals += inputList[index];
                    naturalsList.Add(currentNote);
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", notesList)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturalsList)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharpsList)}");
            Console.WriteLine($"Naturals sum: {Math.Round(sumNaturals, 2)}");
            Console.WriteLine($"Sharps sum: {Math.Round(sumSharps, 2)}");
        }

        public static string NoteFinder(double freq)
        {
            string note = string.Empty;
            string currentFreq = freq.ToString();

            var notesTable = new List<string>
            {
                "C", "261.63", "C#", "277.18", "D", "293.66", "D#", "311.13", "E", "329.63",
                "F", "349.23", "F#", "369.99", "G", "392", "G#", "415.3", "A", "440", "A#", "466.16", "B", "493.88"
            };

            for (int i = 0; i < notesTable.Count; i++)
            {
                if (currentFreq == notesTable[i])
                {
                    note = notesTable[i - 1];
                }
            }
            //switch (freq)
            //{
            //    case 261.63: note = "C"; break;
            //    case 277.18: note = "C#"; break;
            //    case 293.66: note = "D"; break;
            //    case 311.13: note = "D#"; break;
            //    case 329.63: note = "E"; break;
            //    case 349.23: note = "F"; break;
            //    case 369.99: note = "F#"; break;
            //    case 392.00: note = "G"; break;
            //    case 415.30: note = "G#"; break;
            //    case 440.00: note = "A"; break;
            //    case 466.16: note = "A#"; break;
            //    case 493.88: note = "B"; break;
            //}

            return note;
        }
    }
}
