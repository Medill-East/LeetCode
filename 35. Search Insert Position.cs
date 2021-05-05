public class Solution35 {
    public int SearchInsert(int[] nums, int target) {
        int len = nums.Length;
        int result = -1;
        if(len == 0)
        {
            return 0;
        }
        else
        {
            for(int i =0; i< len; i++)
            {
                if(nums[i] == target)
                {
                    result = i;
                    break;
                }
                else if(nums[i] > target)
                {
                    result = i;
                    break;
                }
                else
                {
                    result = len;
                }
            }
            return result ;
        }

    }
}