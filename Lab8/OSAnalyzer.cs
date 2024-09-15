using System.Text.RegularExpressions;

namespace Lab8
{
    public static class OSAnalyzer
    {
        public static MatchCollection FoundPartsWithWindowsMacOS(string input)
        {
            string pattern = "windows(?:\\s+\\w+){5}\\s+macos";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            var matches = regex.Matches(input);
            return matches;
        }
    }
}
