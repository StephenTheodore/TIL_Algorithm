using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        var result = new List<int>();
        
        if (n == 1)
            result.AddRange(num_list.Take(slicer[1]+1));
        else if (n == 2)
            result.AddRange(num_list.Skip(slicer[0]));
        else if (n == 3)
            result.AddRange(num_list.Take(slicer[1]+1).Skip(slicer[0]));
        else
        {
            for (int index = slicer[0]; index <= slicer[1]; index+=slicer[2])
                result.Add(num_list[index]);
        }
        
        return result.ToArray();
    }
}