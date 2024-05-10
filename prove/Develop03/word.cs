namespace ScriptureMemorizer
{
    public class Word
    {
        private string text;
        private bool isHidden;

        public Word(string text)
        {
            this.text = text;
            this.isHidden = false;
        }

        public string GetDisplayText()
        {
            if (this.isHidden)
            {
                return new string('_', this.text.Length);
            }
            else
            {
                return this.text;
            }
        }

        public void Hide()
        {
            this.isHidden = true;
        }

        public void Show()
        {
            this.isHidden = false;
        }

        public bool IsHidden()
        {
            return this.isHidden;
        }
    }
}