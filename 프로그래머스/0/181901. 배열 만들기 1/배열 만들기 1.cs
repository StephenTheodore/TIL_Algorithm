using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k)
    {
        var result = new List<int>();
        for(int num = k; num <= n; num += k)
            result.Add(num);   
        return result.ToArray();
    }
}