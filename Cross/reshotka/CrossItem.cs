using System.Collections.Generic;

namespace reshotka
{
    public class CrossItem
    {     
        public string name {  get; set; }   
        // лист слов
        public List<WordItem> wordList = new List<WordItem> ();

        public CrossItem(string name)
        {
            this.name = name;
        }
        
        public void AddWord(WordItem word)
        {
            wordList.Add(word);
        }
    }
}