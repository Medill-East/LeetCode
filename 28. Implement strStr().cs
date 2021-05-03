public class Solution28
{
    public int StrStr(string haystack, string needle)
    {
        int needleLength = needle.Length;
        int haystackLength = haystack.Length;
        int result = -1;

        // if needle is empty
        // return 0
        if (needleLength == 0)
        {
            return 0;
        }
        // if len(haystack) < len(needle)
        // return -1
        else if (haystackLength < needleLength)
        {
            return -1;
        }
        else
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                // if the start string is the same
                if (haystack[i] == needle[0])
                {
                    // if len(remaning) < len(needle)
                    // return -1
                    if (haystackLength - i < needleLength)
                    {
                        return -1;
                    }
                    // else compare the string start from i, len(needle) 
                    // if true, return the index i
                    else if (Compare2((haystack.Substring(i, needleLength)), needle))
                    {
                        result = i;
                        return result;
                    }
                }
            }
        }
        return result;
    }

    private bool Compare2(string inputS1, string inputS2)
    {
        int len = inputS1.Length;
        int current = 0;
        for (int i = 0; i < len; i++)
        {
            if (inputS1[i] == inputS2[i])
            {
                current += 1;
            }
        }
        if (current == len)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}