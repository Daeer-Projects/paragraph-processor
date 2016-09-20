using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NxteraInterviewProblems
{
    /// <summary>
    /// The function should take a string, and return a dictionary that returns a count of the number of occurrences of
    /// each word in the string.
    /// 
    /// This function has been partially completed, can you finish it?
    /// 
    /// If you were writing this function from scratch, how would you do it, what would you do differently and why?
    /// </summary>
    static class Problem2
    {
        public static Dictionary<string, int> Process(string phrase)
        {
            Dictionary<string, int> wordsAndCount = new Dictionary<string, int>();

            string[] words = phrase.Replace("\"", "").Replace("'", "").Replace(".", "").Replace(",", "").Replace("\n", "").Split(' ');
            for (int index = 0; index <= words.Length; index++)
            {
                string word = words[index];
                wordsAndCount[word] = wordsAndCount[word] + 1;
            }
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> pair in wordsAndCount.OrderByDescending((s) => s.Key))
                dictionary.Add(pair.Key, pair.Value);

            wordsAndCount = dictionary;
            return wordsAndCount;
        }
    }
}
