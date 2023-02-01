using System;

public class Solution {
    public bool solution(string s)
    {
        int count = 0;
        foreach(var ch in s)
        {
            if(ch == '(')
                count++;
            else
                count--;
            if(count < 0)
                break;
        }
        return count == 0;
    }
}