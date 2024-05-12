using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            var promptGenerator = new PromptGenerator();

            while (true)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        var prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        var entryText = Console.ReadLine();
                        journal.AddEntry(new Entry(prompt, entryText));
                        break;
                    case 2:
                        journal.DisplayAll();
                        break;
                    case 3:
                        Console.Write("Enter a filename: ");
                        var filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                        break;
                    case 4:
                        Console.Write("Enter a filename: ");
                        var loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}