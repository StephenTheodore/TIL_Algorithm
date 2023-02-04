using System;

public class Solution {
    public int solution(int n)
    {
        int ret = 0;
        for(int i = 1; i <= n; i++)
        {
            do ret++;
            while(ret % 3 == 0 || ret.ToString().Contains('3'));
        }
        return ret;
    }
}