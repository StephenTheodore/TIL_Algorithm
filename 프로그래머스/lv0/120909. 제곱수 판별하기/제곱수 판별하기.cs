using System;

public class Solution {
    public int solution(int n)
    {
        int offRoot = (int)Math.Sqrt(n);
        
        return Math.Pow(offRoot,2) == n ? 1 : 2;
    }
}