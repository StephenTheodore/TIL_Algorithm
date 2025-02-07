using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        var result = new List<string>();
        var index = Array.FindIndex(str_list, str => str == "l" || str == "r");
        
        if (index >= 0)
        {
            if (str_list[index] == "l")
                result.AddRange(str_list.Take(index));
            else
                result.AddRange(str_list.Skip(index + 1).Take(str_list.Length));
        }
        
        return result.ToArray();
    }
}