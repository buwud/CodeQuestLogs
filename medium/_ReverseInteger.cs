public class _ReverseInteger
{
    public int Reverse(int x)
    {
        if (x == int.MinValue)
        {
            return 0;
        }

        var sign = Math.Sign(x);

        x = Math.Abs(x);
        char[] num = x.ToString().ToCharArray();
        Array.Reverse(num);

        long res = Convert.ToInt64(new string(num)) * sign;
        if (res > int.MaxValue || res < int.MinValue)
            return 0;
        else
            return Convert.ToInt32(res);
    }
}
