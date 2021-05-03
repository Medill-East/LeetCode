public class Solution27
{
    public int RemoveElement(int[] nums, int val)
    {
        int len = nums.Length;
        int result = 0;
        if (len == 0)
        {
            return 0;
        }
        else if (len == 1 && nums[0] != val)
        {
            return 1;
        }
        else
        {
            int i = 0;
            for (int j = 1; j < len + 1; j++)
            {
                if (nums[j - 1] != val)
                {
                    result += 1;
                    nums[i] = nums[j - 1];
                    i++;
                }
                else
                {
                    nums[i] = nums[j - 1];
                }
            }
            return result;
        }

    }
}