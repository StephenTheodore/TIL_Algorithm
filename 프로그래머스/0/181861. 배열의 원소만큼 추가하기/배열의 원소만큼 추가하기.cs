using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr)
    {
        var result = new List<int>();
        foreach(int elem in arr)
        {
            for (int rep = 0; rep < elem; rep++)
                result.Add(elem);
        }
        
        return result.ToArray();
    }
}