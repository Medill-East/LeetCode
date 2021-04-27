public class Solution53 {
    //202002170126
    public int MaxSubArray(int[] nums) {
        int result = nums[0];                   //设定结果为第一个
        int maxTemp = 0;                        //假定最大值为0
        for (int i = 0; i < nums.Length; i++)   //遍历数组
        {
            maxTemp += nums[i];                 //当前最大值和下一项相加

            if(maxTemp>result)                  //如果相加结果大于”结果“
            {
                result = maxTemp;               //更新最大值为相加结果
            }
            
            if(maxTemp < 0)                     //如果相加结果小于0
            {
                maxTemp = 0;                    //舍弃目前结果
            }
        }
        return result;      
    }
}