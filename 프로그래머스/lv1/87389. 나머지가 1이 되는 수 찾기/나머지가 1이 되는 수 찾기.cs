using System;

public class Solution {
    public int solution(int n) 
    {
        int x;
        for(x = 2; x < n; x++)
        {
            if(n % x == 1)
                break;
        }
        return x;
    }
}