using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names)
    {
        var result = new List<string>();
        for (int index = 0; index < names.Length; index += 5)
            result.Add(names[index]);
        
        return result.ToArray();
    }
}