using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        var result = new List<int>();
        for (int index = intervals[0,0]; index <= intervals[0,1]; index++)
            result.Add(arr[index]);
        for (int index = intervals[1,0]; index <= intervals[1,1]; index++)
            result.Add(arr[index]);
        
        return result.ToArray();
    }
}