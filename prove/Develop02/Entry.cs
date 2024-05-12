using System;

namespace JournalProgram
{
    public class Entry
    {
        public string Prompt { get; }
        public string EntryText { get; }
        public DateTime Date { get; }

        public Entry(string prompt, string entryText)
        {
            Prompt = prompt;
            EntryText = entryText;
            Date = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine($"Prompt: {Prompt}");
            Console.WriteLine($"Date: {Date.ToShortDateString()}");
            Console.WriteLine($"Entry: {EntryText}");
            Console.WriteLine();
        }
    }
}