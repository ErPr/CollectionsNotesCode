using System.Collections.Generic;

namespace SetsAndDictionaries
{
    public class WordCount
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

        public Dictionary<string, int> WordsWithCountGreaterThan(int count)
        {
            Dictionary<string, int> countDictionary = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> pair in WordCount)
            {
                if (pair.Value > count)
                {
                    countDictionary.Add(pair.Key, pair.Value);
                }
            }
            return countDictionary;
        }
    }
}
