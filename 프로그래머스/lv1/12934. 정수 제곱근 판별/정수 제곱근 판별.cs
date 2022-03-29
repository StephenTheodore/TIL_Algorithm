using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        if(n==1)
            return 4;
        answer = (long)Math.Sqrt(n);
        if(Math.Pow(answer,2) == n)
            return (answer+1)*(answer+1);
        else
            return -1;
    }
}