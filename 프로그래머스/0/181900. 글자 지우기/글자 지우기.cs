using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int[] indices) {
        var chars = my_string.ToList();
        foreach (var index in indices)
            chars[index] = '\0';
        
        return string.Join("", chars.Where(ch => ch != '\0'));
    }
}