public class Solution14 {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1)
        {
            return strs[0];
        }
        
        string result = "";
        int shortestLength = ShortestLength(strs);
        bool isEqual = false;

        for(int i = 0; i < shortestLength; i ++)
        {
            for(int j = 0; j < strs.Length-1; j++)
            {
                if(string.Equals(strs[j][i], strs[j+1][i]))
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;         
                }
            }
            if(isEqual == true)
            {
                result += strs[0][i];
            }
            else
            {
                break;
            }
        }

        return result;
    }

    private int ShortestLength(string[] strs)
    {
        int shortest = 999;
        for(int i = 0; i < strs.Length; i ++)
        {
            if (strs[i].Length < shortest)
            {
                shortest = strs[i].Length;
            }
        }
        return shortest;
    }
}