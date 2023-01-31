using System;

public class Solution {
    public int solution(int num, int k)
    {
        int ret = num.ToString().IndexOf(k.ToString());
        
        return ret != -1 ? ret+1 : ret;
    }
}