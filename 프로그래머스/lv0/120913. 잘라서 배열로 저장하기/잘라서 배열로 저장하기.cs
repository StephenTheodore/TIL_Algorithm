using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) 
    {
        var list = new List<string>();
        
        for(int i = 0; i < my_str.Length; i+=n)
            list.Add(string.Join("",my_str.Skip(i).Take(n)));
        
        return list.ToArray();
    }
}