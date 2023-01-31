using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        bool[] filter = new bool[101];
        for(int i = 2; i <= 100; i++)
        {
            if(filter[i] == false)
            {
                for(int j = i + i; j <= 100; j += i)
                    filter[j] = true;
            }
        }
        
        return filter.Take(n+1).Count(b => b == true);
    }
}