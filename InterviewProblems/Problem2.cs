using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace InterviewProblems
{
    /// <summary>
    /// The function should take a string, and return a dictionary that returns a count of the number of occurrences of
    /// each word in the string.
    ///
    /// This function has been partially completed, can you finish it? - Yes.
    ///
    /// If you were writing this function from scratch, how would you do it, what would you do differently and why?
    ///
    /// What I would do:
    /// 1. It is part of a utility and I would make a utility
    /// solution / project.
    ///
    /// 2. I would extract it to an interface so that it could be mocked using moq, nsubstitute or fake it easy.
    ///
    /// 3. I would then have the build server create the solution / project as a NuGet package.
    ///
    /// 4. Using the existing test I have created, I would then start to think how I would change this method.
    ///
    /// 5. The code didn't work, as the dictionary needed the words inserted first.  As the phrase is being split into
    /// a string array, I didn't need the extra dictionary.  Then used a concurrent dictionary to add or update using
    /// the word passed in.  If the word existed then the count would be increased.
    ///
    /// 6. The replacing of the characters could be made better, but I'm not sure how you could replace any non-letter
    /// character.  Unless you had another utility method that uses regex to go through a list of specified characters
    /// and replace them with empty spaces.
    ///
    /// 7. This method also uses two loops.  One to add or update from the string array, the other to get the values
    /// into another dictionary, in a specified order.  You might be able to order the concurrent dictionary in the
    /// return method.
    /// 
    /// 8. Changed the current method to not add an empty string to the dictionary.
    /// </summary>
    public static class Problem2
    {
        public static Dictionary<string, int> Process(string phrase)
        {
            string[] words =
                phrase.Replace("\"", string.Empty)
                    .Replace("'", string.Empty)
                    .Replace(".", string.Empty)
                    .Replace(",", string.Empty)
                    .Replace("\n", string.Empty)
                    .Replace("!", string.Empty)
                    .Replace("?", string.Empty)
                    .Split(' ');

            var wordCount = new ConcurrentDictionary<string, int>();

            foreach (var word in words)
            {
                wordCount.AddOrUpdate(word, 1, (key, existingValue) =>
                {
                    if (word == key)
                    {
                        existingValue++;
                    }

                    return existingValue;
                });
            }

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var pair in wordCount.OrderByDescending((s) => s.Key))
            {
                if (!string.IsNullOrEmpty(pair.Key))
                {
                    dictionary.Add(pair.Key, pair.Value);
                }
            }

            return dictionary;
        }
    }
}