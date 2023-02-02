using System;

public class Solution {
    public int[] solution(int n, int m)
    {
        int GCD, LCM;
        
        GCD = GetGCD(Math.Max(n,m), Math.Min(n,m));
        LCM = n*m / GCD;
        
        return new int[] {GCD, LCM};
    }
    int GetGCD(int max, int min)
    {
        if(max % min == 0)
            return min;
        else
            return GetGCD(min, max % min);
    }
}