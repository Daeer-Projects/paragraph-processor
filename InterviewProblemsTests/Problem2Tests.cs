using FluentAssertions;
using InterviewProblems;
using System.Collections.Generic;
using Xunit;

namespace InterviewProblemsTests
{
    public class Problem2Tests
    {
        /// <summary>
        /// A passing test with the changes made to the existing version.
        /// The original version had problems with the dictionary.
        /// </summary>
        [Fact]
        public void given_short_phrase_when_processed_returns_expected_dictionary()
        {
            // Arrange.
            const string phrase = @"Hello world! Oh dear! What has the world been up to?";
            var expectedDictionary = new Dictionary<string, int>
            {
                {"Hello", 1},
                {"world", 2},
                {"Oh", 1},
                {"dear", 1},
                {"What", 1},
                {"has", 1},
                {"the", 1},
                {"been", 1},
                {"up", 1},
                {"to", 1}
            };

            // Act.
            var result = Problem2.Process(phrase);

            // Assert.
            result.ShouldBeEquivalentTo(expectedDictionary);
        }
    }
}