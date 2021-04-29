public class Solution26
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        else if (nums.Length == 1)
        {
            return 1;
        }
        else
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    nums[i + 1] = nums[j];
                    i++;
                }
            }
            return i + 1;
        }

    }
}