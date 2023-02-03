using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] sizes) 
    {
        var horizontal = new List<int>();
        var vertical = new List<int>();
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            horizontal.Add(Math.Max(sizes[i,0], sizes[i,1]));
            vertical.Add(Math.Min(sizes[i,0], sizes[i,1])); 
        }
        
        return horizontal.OrderByDescending(n => n).First() * vertical.OrderByDescending(n => n).First();
    }
}