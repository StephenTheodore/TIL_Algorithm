using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) 
    {
        var suffixes = new List<string>();
        
        for (int count = 1; count <= my_string.Length; count++)
            suffixes.Add($"{my_string.Substring(my_string.Length - count, count)}");
        
        return suffixes.OrderBy(suffix => suffix).ToArray();
    }
}