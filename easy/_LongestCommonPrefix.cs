public class _LongestCommonPrefix
{
    //Input: strs = ["flower","flow","flight"]
    //Output: "fl"

    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1); //removes the last character

                if (string.IsNullOrEmpty(prefix))
                    return "";
            }
        }

        return prefix;
    }
}
