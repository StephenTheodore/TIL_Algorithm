using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        var dict = new Dictionary<int,int >();
        
        dict[1] = 1;
        for(int i = 2; i <= 10; i++)
            dict[i] = dict.Last().Value * i;
        
        return dict.Where(d => d.Value <= n).Max(d => d.Key);
    }
}