using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference reference;
        private List<Word> words;

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            this.words = new List<Word>();
            string[] wordStrings = text.Split(' ');
            foreach (string word in wordStrings)
            {
                this.words.Add(new Word(word));
            }
        }

        public string GetDisplayText()
        {
            string displayText = "";
            foreach (Word word in this.words)
            {
                displayText += word.GetDisplayText() + " ";
            }
            return displayText;
        }

        public void HideRandomWords(int numberToHide)
        {
            // TODO: Implement method
        }

        public bool IsCompletelyHidden()
        {
            // TODO: Implement method
            return false;
        }
    }
}