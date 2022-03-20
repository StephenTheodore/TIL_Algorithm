public class Solution {
    public long solution(int n)
    {
        long next = 0;
        long pre = 1;
        long cur = 2;

        if(n<3)
            return n;
        for (int i = 3; i <= n; i++)
        {
            next = pre + cur;
            pre = cur;
            cur = next % 1234567;
        }

        return next % 1234567;
    }
}