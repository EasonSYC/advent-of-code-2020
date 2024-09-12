namespace AdventOfCode;
internal class Day6
{
    enum CountOptions
    {
        Or,
        And
    }
    private static int CountResponse(List<string> responses, CountOptions option)
    {
        HashSet<char> groupAnswers = [];
        if (option == CountOptions.And)
        {
            for (char c = 'a'; c <= 'z'; ++c)
            {
                groupAnswers.Add(c);
            }
        }
        foreach (string str in responses)
        {
            IEnumerable<char> currentAnswer = str.Where(char.IsAsciiLetterLower);
            if (option == CountOptions.Or)
            {
                groupAnswers.UnionWith(currentAnswer);
            }
            else
            {
                groupAnswers.IntersectWith(currentAnswer);
            }
        }
        return groupAnswers.Count();
    }

    internal static int Solution(string inputPath, bool IsPart1)
    {
        int ans = 0;
        List<string> lines = new(File.ReadAllLines(inputPath));
        List<string> groupResult = [];
        for (int i = 0; i < lines.Count; ++i)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
            {
                ans += CountResponse(groupResult, IsPart1 ? CountOptions.Or : CountOptions.And);
                groupResult = [];
            }
            else
            {
                groupResult.Add(lines[i]);
            }
        }

        ans += CountResponse(groupResult, IsPart1 ? CountOptions.Or : CountOptions.And);

        return ans;
    }
}