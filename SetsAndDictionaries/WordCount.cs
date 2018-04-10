using System.Collections.Generic;

namespace SetsAndDictionaries
{
    public class LexicalAnalysis
    {
        public Dictionary<string, int> WordCount = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if (WordCount.ContainsKey(word))

            {
                WordCount[word]++;
            }
            else
            {
                WordCount.Add(word, 1);
            }

        }
    }
}
