using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        var result = new List<int>();
        for (int queryIndex = 0; queryIndex < queries.GetLength(0); queryIndex++)
        {
            int startIndex = queries[queryIndex, 0];
            int endIndex = queries[queryIndex, 1];
            
            for (int arrIndex = startIndex; arrIndex <= endIndex; arrIndex++)
                arr[arrIndex]++;
        }
        
        return arr;
    }
}