using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index)
    {
        var list = new List<char>();
        for(char ch = 'a'; ch <= 'z'; ch++)
        {
            if(skip.Contains(ch) == false)
               list.Add(ch);
        }
        
        return string.Join("", s.Select(c => list[(list.IndexOf(c) + index) % list.Count]));
    }
}