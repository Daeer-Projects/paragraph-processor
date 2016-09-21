using FluentAssertions;
using InterviewProblems;
using Xunit;

namespace InterviewProblemsTests
{
    public class Problem1Tests
    {
        [Fact]
        public void given_short_phrase_and_large_value_when_processed_returns_full_phrase()
        {
            // Arrange.
            const string expected = "Hello world.        \r\n";
            
            // Act.
            var result = Problem1.Process(expected, 20);

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void given_long_phrase_and_high_value_when_processed_returns_correctly_split_phrase()
        {
            // Arrange.
            const string expected = @"Lorem ipsum dolor sit amet, mel magna dolore rationibus no, ea
pericula gubergren has. In vidisse percipit vix, qui amet adipiscing
no, eum ad malis dicit. Ut eirmod commune eos. Vix case officiis no,
decore nominavi te quo, stet appareat philosophia his ei. Te sea viris
nemore neglegentur, ad eam dicit detracto partiendo. Minim impedit
nominavi ut has, feugiat recteque id usu, at pro debitis forensibus
delicatissimi. Assum accommodare qui ad. Officiis neglegentur ut ius,
aliquip invenire reformidans ex sit. Te legere disputationi his, nam
ad utamur omittam apeirian. Cu vero paulo oportere qui, in suscipit
lucilius consetetur ius. Ludus vocibus ad sed, ex vel eirmod feugiat
nominavi, nostro inciderint mediocritatem vix et. At has sale denique,
quo platonem democritum ullamcorper id. Modus similique sea at.
";

            const string phrase = @"
Lorem ipsum dolor sit amet, mel magna dolore rationibus no, ea pericula gubergren has. In vidisse percipit vix, qui amet adipiscing no, eum ad malis dicit. Ut eirmod commune eos. Vix case officiis no, decore nominavi te quo, stet appareat philosophia his ei. Te sea viris nemore neglegentur, ad eam dicit detracto partiendo. Minim impedit nominavi ut has, feugiat recteque id usu, at pro debitis forensibus delicatissimi. Assum accommodare qui ad. 
Officiis neglegentur ut ius, aliquip invenire reformidans ex sit. Te legere disputationi his, nam ad utamur omittam apeirian. Cu vero paulo oportere qui, in suscipit lucilius consetetur ius. Ludus vocibus ad sed, ex vel eirmod feugiat nominavi, nostro inciderint mediocritatem vix et. At has sale denique, quo platonem democritum ullamcorper id. Modus similique sea at.";

            // Act.
            var result = Problem1.Process(phrase, 70);

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void given_short_phrase_and_small_value_when_processed_returns_correct_phrase()
        {
            // Arrange.
            const string expected = @"Lorem ipsum dolor
sit amet, mel magna
dolore rationibus
no, ea pericula note
gubergren has.
";
            const string phrase = @"Lorem ipsum dolor sit amet, mel magna dolore rationibus no, ea pericula note gubergren has.";

            // Act.
            var result = Problem1.Process(phrase, 20);

            // Assert.
            result.Should().Be(expected);
        }
    }
}