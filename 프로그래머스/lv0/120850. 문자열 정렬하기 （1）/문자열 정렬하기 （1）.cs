using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string)
    {
        List<int> nums = new List<int>();
        
        foreach(var ch in my_string)
        {
            if(char.IsNumber(ch))
                nums.Add((int)char.GetNumericValue(ch));
        }
        return nums.OrderBy(n => n).ToArray();
    }
}