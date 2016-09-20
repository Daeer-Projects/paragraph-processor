using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NxteraInterviewProblems
{
    /// <summary>
    /// The function should take a string and a desired line length. It should return a new string with newline
    /// characters inserted so that each line is as long as possible, but no more than the desired line length. You
    /// should only insert line breaks between words - you should not break in the middle of a word.
    /// 
    /// This function has been partially completed, can you finish it?
    /// 
    /// If you were writing this function from scratch, how would you do it, what would you do differently and why?
    /// </summary>
    public static class Problem1
    {
        public static string Process(string phrase, int lengthOfLines)
        {
            var chars = phrase.Replace(Environment.NewLine, "");
            var finalStrings = new List<string>();
            int start = 0;
            int end = 0;
            var finished = false;
            while (!finished)
            {
                end = start + lengthOfLines;
                if (end >= chars.Length)
                {
                    finished = true;
                    finalStrings.Add(chars.Substring(start, chars.Length - start));
                    break;
                }

                while (chars[end] != ' ')
                {
                    end--;
                }

                var chunk = chars.Substring(start, end - start);
                finalStrings.Add(chunk);
                start = end + 1;
            }

            var final = string.Empty;
            finalStrings.ForEach((x) => final += x + Environment.NewLine);
            return final;
        }

    }
}
