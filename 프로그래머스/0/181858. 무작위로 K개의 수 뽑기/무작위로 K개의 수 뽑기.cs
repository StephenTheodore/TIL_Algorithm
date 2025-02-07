using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k)
    {
        var numbers = arr.Distinct().ToList();
        
        if (numbers.Count > k)
            numbers = numbers.Take(k).ToList();
        else if (numbers.Count < k)
        {
            while (numbers.Count < k)
                numbers.Add(-1);
        }
            
        return numbers.ToArray();
    }
}