using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start_num, int end_num)
    {
        var result = new List<int>();
        for (int num = start_num; num >= end_num; num--)
            result.Add(num);
        return result.ToArray();
    }
}