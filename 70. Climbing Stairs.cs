public class Solution70 {
    //20200218 斐波那契
    public int ClimbStairs(int n) {
        //F(n) = F(n-1) + F(n-2)
        if (n<3)
        {
            return n;
        }
        else
        {
            int a =1, b=2, temp;
            for (int i = 3; i <= n; i++)
            {
                temp = a;
                a = b;
                b = temp+b;
            }
            return b;

            //return ClimbStairs(n-1)+ClimbStairs(n-2);
        }
    }

}