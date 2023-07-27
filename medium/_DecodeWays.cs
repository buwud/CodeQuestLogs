using System.Text.Json;

public class _DecodeWays
{
    public int NumDecodings(string s)
    {
        int n = s.Length;

        // Temel durum: boş bir dizge 1 şekilde çözümlenir.
        int[] dp = new int[n + 1];
        dp[0] = 1;

        // Eğer ilk karakter '0' ise, çözümlenemez. Bu nedenle dp[1] 0 olacak,
        // aksi halde 1 olacak.
        dp[1] = s[0] == '0' ? 0 : 1;

        for (int i = 2; i <= n; i++)
        {
            // Son rakam tek başına çözümlenebilir (yani '0' değilse),
            // dp[i - 1]'in değerini dp[i]'ye ekliyoruz.
            if (1 <= int.Parse(s[i - 1].ToString()) && int.Parse(s[i - 1].ToString()) <= 9)
            {
                dp[i] += dp[i - 1];
            }

            // Son iki rakamın geçerli bir çözüm oluşturup oluşturmadığını kontrol ediyoruz.
            int twoDigit = int.Parse(s.Substring(i - 2, 2));
            if (10 <= twoDigit && twoDigit <= 26)
            {
                dp[i] += dp[i - 2];
            }
        }

        return dp[n];
    }
}
