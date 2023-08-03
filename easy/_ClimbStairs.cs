public class _ClimbStairs
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
            return 1;
        if (n == 2)
            return 2;

        int result = 0;
        int i1 = 2;
        int i2 = 1;

        for (int i = 3; i <= n; i++)
        {
            result = i1 + i2;
            i2 = i1;
            i1 = result;
        }

        return result;
    }
}
