using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers)
    {
        var list = new List<int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
                list.Add(numbers[i] + numbers[j]);
        }
        
        return list.Distinct().OrderBy(n => n).ToArray();
    }
}