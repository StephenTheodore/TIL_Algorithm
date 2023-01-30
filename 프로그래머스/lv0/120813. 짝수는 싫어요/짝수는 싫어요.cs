using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) 
    {
        List<int> arrAscend = new List<int>();
        
        for(int i = 1; i <= n; i+=2)
            arrAscend.Add(i);
        
        return arrAscend.ToArray();
    }
}