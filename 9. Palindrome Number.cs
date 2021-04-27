using System;

public class Solution9
{
    public bool IsPalindrome(int x)
    {
        string strX = x.ToString();
        if (string.Equals(strX[0], '-'))
        {
            return false;
        }
        else
        {
            if (string.Equals(strX, Reversal(strX)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public string Reversal(string input)
    {
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        string result = new string(array);
        Console.WriteLine(result);
        return result;
    }
}