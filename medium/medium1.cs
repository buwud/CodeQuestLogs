public class medium0
{
    public void Main()
    {
        int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };

        int k = RemoveDuplicates(nums);
    }

    public int RemoveDuplicates(int[] nums)
    {
        int length = nums.Length;
        int index = 0;

        for (int i = 0; i < length; i++)
        {
            if (index < 2 || nums[i] != nums[index - 2])
            {
                nums[index] = nums[i];
                index++;
            }
        }

        return index;
    }
}
