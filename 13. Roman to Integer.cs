public class Solution {
  public int RomanToInt (string s) {
    // string a = "III";
    // System.Console.WriteLine (a[0]);
    // System.Console.WriteLine (string.Equals(a[0], 'I'));
    if (s.Length == 0)
        return 0;
    else if (s.Length >=2 && string.Equals(s[0], 'I') && string.Equals(s[1], 'V'))
    {
        return RomanToInt(s.Substring(2, s.Length-2)) + 4;
    }
    else if (s.Length >=2 && string.Equals(s[0], 'I') && string.Equals(s[1], 'X'))
    {
        return RomanToInt(s.Substring(2, s.Length-2)) + 9;
    }
    else if (s.Length >=2 && string.Equals(s[0], 'X') && string.Equals(s[1], 'L'))
    {
        return RomanToInt(s.Substring(2, s.Length-2)) + 40;
    }
    else if (s.Length >=2 && string.Equals(s[0], 'X') && string.Equals(s[1], 'C'))
    {
        return RomanToInt(s.Substring(2, s.Length-2)) + 90;
    }
    else if (s.Length >=2 && string.Equals(s[0], 'C') && string.Equals(s[1], 'D'))
    {
        return RomanToInt(s.Substring(2, s.Length-2)) + 400;
    }
    else if (s.Length >=2 && string.Equals(s[0], 'C') && string.Equals(s[1], 'M'))
    {
        return RomanToInt(s.Substring(2, s.Length-2)) + 900;
    }
    else if (string.Equals(s[0], 'I'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 1;
    }
    else if (string.Equals(s[0], 'V'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 5;
    }
    else if (string.Equals(s[0], 'X'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 10;
    }
    else if (string.Equals(s[0], 'L'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 50;
    }
    else if (string.Equals(s[0], 'C'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 100;
    }
    else if (string.Equals(s[0], 'D'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 500;
    }
    else if (string.Equals(s[0], 'M'))
    {
        return RomanToInt(s.Substring(1, s.Length-1)) + 1000;
    }
    return RomanToInt(s.Substring(1, s.Length-1));
  }
}
