using System;

public class Solution {
    public int solution(int n) 
    {
        int count;
        for(count = 1; count < n; count++)
        {
            if((6*count)%n == 0)
                break;
        }
        return count;
    }
}