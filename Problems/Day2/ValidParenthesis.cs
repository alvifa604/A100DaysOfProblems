namespace Problems.Day2;

public class ValidParenthesis
{
    public static bool IsValid(string s)
    {
        Dictionary<char, char> parenthesis = [];
        parenthesis.Add(')', '(');
        parenthesis.Add(']', '[');
        parenthesis.Add('}', '{');

        Stack<char> stackedParenthesis = [];

        for (int i = 0; i < s.Length; i++)
        {
            char curr = s[i];

            if (stackedParenthesis.Count == 0)
            {
                stackedParenthesis.Push(curr);
                continue;
            }

            char peek = stackedParenthesis.Peek();
            if (!parenthesis.TryGetValue(curr, out char par))
            {
                stackedParenthesis.Push(curr);
                continue;
            }

            if (peek == par)
            {
                stackedParenthesis.Pop();
            }
            else
            {
                stackedParenthesis.Push(curr);
            }
        }

        return stackedParenthesis.Count == 0;
    }
}
