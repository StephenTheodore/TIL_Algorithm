using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) 
    {
        var list = emergency.OrderByDescending(e => e).ToList();
        return emergency.Select(e => list.IndexOf(e) + 1).ToArray();
    }
}