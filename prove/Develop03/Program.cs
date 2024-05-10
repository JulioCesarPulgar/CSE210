using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            scripture.DisplayScripture();
            scripture.HideRandomWords(5);
            scripture.DisplayScripture();
            while (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(5);
                scripture.DisplayScripture();
            }
            Console.WriteLine("Scripture is completely hidden. Press enter to exit.");
            Console.ReadLine();
        }
    }
}