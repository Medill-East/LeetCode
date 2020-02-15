public class Solution1 {
    public int[] TwoSum(int[] nums, int target) {
        // Array.Sort(nums);
        // int low = 0;
        // int high = nums.Length-1;
        // bool found = false;
        // do
        // {
        //     if(nums[low] + nums[high] > target)
        //     {
        //         high /=2;
        //     }
        //     else if (nums[low] + nums[high] < target)
        //     {
        //         low = (low+high)/2;
        //     }
        //     else if(nums[low] + nums[high] == target)
        //     {
        //         found = true;
        //     }
        // } while (found == false);
        // return new int[]{low,high};

        // bool found = false;
        int low = 0;
        int high = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if(nums[i]+nums[j] == target)
                {
                    low = i;
                    high = j;
                    break;
                }
            }
        }
        return new int[]{low,high};
    }
}