using System;

public class Solution {
    public int solution(int i, int j, int k)
    {
        int count;
        for(count = 0; i <= j; i++)
        {
            foreach(var ch in i.ToString())
            {
                if(ch == (char)k + '0')
                    count++;
            }
        }
        return count;
    }
}