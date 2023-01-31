using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) 
    {
        var list = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
                list.Add(i);
        }
        return list.ToArray();
    }
}