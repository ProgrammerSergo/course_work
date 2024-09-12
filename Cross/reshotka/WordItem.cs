namespace reshotka
{
    public class WordItem
    {
        public int ID; 
        public string word;
        public string help;

        public WordItem(int ID, string word, string help)
        {
            this.ID = ID;
            this.word = word;
            this.help = help;
        }
    }
}