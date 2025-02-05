using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) 
    {
        var result = new List<int>();
        for (int index = 0; index < num_list.Length; index += n)
            result.Add(num_list[index]);
        
        return result.ToArray();
    }
}