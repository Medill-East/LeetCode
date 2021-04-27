public class Solution20 {
    //202002160116
    public bool IsValid(string s) {
    //     //  string[] strArray = s.Split(""); //字符串转数组
    //     if(s.Length == 0)
    //     {
    //         return true;
    //     }
    //     if(s.Length%2 != 0)
    //     {
    //         return false;
    //     }
    //      byte[] array = System.Text.Encoding.ASCII.GetBytes(s);
    //      for (int i = 0; i < s.Length/2; i++)
    //      {
    //         if( (((int)array[s.Length-1-i] - (int)array[i]) == 1) ||
    //              (((int)array[s.Length-1-i] - (int)array[i]) == 2))
    //         {

    //         }
    //         else
    //         {
    //             for (int j = 0; j < s.Length; j+=2)
    //             {
    //                 if( (((int)array[j+1] - (int)array[j]) == 1) ||
    //                         (((int)array[j+1] - (int)array[j]) == 2))
    //                 {

    //                 }
    //                 else
    //                 {
    //                     return false;
    //                 }
    //             }
    //         }
    //      }
    //      return true;
        int num = s.Length;
        for (int i = 0; i < num/2+1; i++)
        {
            s = s.Replace("()","");
            s = s.Replace("[]","");
            s = s.Replace("{}","");
        }
        return (s=="");

     }
    
}