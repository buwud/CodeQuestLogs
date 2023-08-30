public class _RemoveDuplicates
{
    public int RemoveDuplicates(int[] nums)
    {
        int counter = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if ((nums[i] ^ nums[i - 1]) != 0)
            {
                counter++;
                nums[counter] = nums[i];
            }
        }

        return 1 + counter;
    }
}
