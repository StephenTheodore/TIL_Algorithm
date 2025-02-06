using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int m, int c) {
        var list = new List<string>();
        for (int index = 0; index < my_string.Length; index+=m)
            list.Add(string.Join("", my_string.Skip(index).Take(m)));
        
        return string.Join("", list.Select(str => str.Length >= c ? str[c - 1] : '\0'));
    }
}