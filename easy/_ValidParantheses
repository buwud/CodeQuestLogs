public class _ValidParantheses
{
    public static bool IsValid(string s)
    {
        bool result = true;
        for (int i = 1; i < s.Length; i += 2)
        {
            if (s[i - 1] == ')' || s[i - 1] == '}' || s[i - 1] == ']')
                result = false;
            if (s[i - 1] == '(' && s[i] != ')')
                result = false;
            if (s[i - 1] == '{' && s[i] != '}')
                result = false;
            if (s[i - 1] == '[' && s[i] != ']')
                result = false;
        }
        //"(){}}{"
        return result;
    }
}

/*
while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }
        return s.Length == 0;
*/
