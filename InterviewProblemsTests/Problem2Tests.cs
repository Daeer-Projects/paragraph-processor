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

        /// <summary>
        /// A passing test, made possible with a small change to the method.  We don't want to have an
        /// entry for an empty string.
        /// </summary>
        [Fact]
        public void given_phrase_with_punctuation_when_processed_returns_empty_dictionary()
        {
            // Arrange.
            const string phrase = "\"'.,!?";

            // Act.
            var result = Problem2.Process(phrase);

            // Assert.
            result.Count.Should().Be(0);
        }

        /// <summary>
        /// A simple test to ensure we get the correct count of the same word.
        /// </summary>
        [Fact]
        public void given_phrase_with_same_word_returns_one_entry()
        {
            // Arrange.
            const string phrase = "hello hello hello hello";

            // Act.
            var result = Problem2.Process(phrase);

            // Assert.
            result.Count.Should().Be(1);
        }

        /// <summary>
        /// A simple test to ensure we get the expected dictionary.
        /// </summary>
        [Fact]
        public void given_phrase_with_same_word_returns_correct_dictionary()
        {
            // Arrange.
            const string phrase = "hello hello hello hello";
            var expectedDictionary = new Dictionary<string, int>
            {
                {"hello", 4}
            };

            // Act.
            var result = Problem2.Process(phrase);

            // Assert.
            result.ShouldBeEquivalentTo(expectedDictionary);
        }

        /// <summary>
        /// A simple test to ensure we get the expected dictionary depending on the case of the word.
        /// </summary>
        [Fact]
        public void given_phrase_with_same_word_but_with_different_case_returns_correct_dictionary()
        {
            // Arrange.
            const string phrase = "hello Hello hello hello";
            var expectedDictionary = new Dictionary<string, int>
            {
                {"hello", 3},
                {"Hello", 1}
            };

            // Act.
            var result = Problem2.Process(phrase);

            // Assert.
            result.ShouldBeEquivalentTo(expectedDictionary);
        }
    }
}