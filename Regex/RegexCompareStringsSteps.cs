using FluentAssertions;
using TechTalk.SpecFlow;

namespace Regex
{
    [Binding]
    public sealed class RegexCompareStringsSteps
    {
        [When(@"Compare pattern with line regex says result")]
        public void WhenComparePatternWithLineRegexSaysResult()
        {
            var regex = new System.Text.RegularExpressions.Regex("");
            var line = $"otdrs/a3-1/tcp_proxy";

            regex.IsMatch(line).Should().BeTrue();
        }

    }
}
