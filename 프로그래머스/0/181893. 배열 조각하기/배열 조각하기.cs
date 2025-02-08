using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        var result = arr.AsEnumerable();
        for (int index = 0; index < query.Length; index++)
        {
            if (index % 2 == 0)
                result = result.Take(query[index] + 1);
            else
                result = result.Skip(query[index]);
        }
        
        return result.ToArray();
    }
}