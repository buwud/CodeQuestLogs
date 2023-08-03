public class _MyAtoi
{
    public int MyAtoi(string s)
    {
        long result = 0;
        int sign = 1;

        int i = 0;
        while (i < s.Length && char.IsWhiteSpace(s[i]))
            i++;

        if (i < s.Length && (s[i] == '+' || s[i] == '-'))
        {
            sign = (s[i] == '+') ? 1 : -1;
            i++;
        }

        while (i < s.Length && char.IsDigit(s[i]))
        {
            int digit = s[i] - '0';
            if ((result = result * 10 + digit) > int.MaxValue)
                return (sign == 1) ? int.MaxValue : int.MinValue;
            i++;
        }

        return (int)(result * sign);
    }
}
