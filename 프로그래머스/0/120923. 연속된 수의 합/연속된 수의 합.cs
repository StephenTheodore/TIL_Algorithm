using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num, int total) {
        var result = new List<int>();
        
        int center = total / num;
        int evenOffset = (num % 2 == 0) ? 1 : 0;
        for (int index = -num / 2 + evenOffset; index <= num / 2; index++)
            result.Add((int)(center + index));
        
        return result.ToArray();
    }
}