using System;
using System.Collections.Generic;

namespace InterviewProblems
{
    /// <summary>
    /// The function should take a string and a desired line length. It should return a new string with newline
    /// characters inserted so that each line is as long as possible, but no more than the desired line length. You
    /// should only insert line breaks between words - you should not break in the middle of a word.
    /// 
    /// This function has been partially completed, can you finish it? - No, not it its current form.
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
    /// 4. Using the existing tests I have created, I would then start to think how I would change this method.
    /// 
    /// 5. The code works for the most part, except for the replacing of the new line.  This is only a problem
    /// when the phrase has a new line in it at the exact point where the lengthOfLines is supposed to cut it off.
    /// 
    /// 6. I think I would change the new lines to empty spaces first.
    /// 
    /// 7. Then I would split the phrase to create an array of strings.
    /// 
    /// 8. Then I would build up a line by adding the strings in order until my line reached the specified length.
    /// 
    /// 9. I would then add that line to the finalStrings list or even a StringBuilder using AppendLine.
    /// </summary>
    public static class Problem1
    {
        public static string Process(string phrase, int lengthOfLines)
        {
            // This is the line that causes an issue if the lengthOfLines matches a
            // new line in the phrase.
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
