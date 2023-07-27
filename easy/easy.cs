//palindrom

public class easy
{
    public void Main()
    {
        Console.WriteLine(IsPalindrome(10));
    }

    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        int i = 0;
        string val = x.ToString();
        while (i < val.Length)
        {
            if (val[i] != val[val.Length - i - 1])
                return false;
            i++;
        }

        return true;
    }
}
