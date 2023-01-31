using System;
using System.Linq;

public class Solution {
    public long solution(long n)
    {
        string str = string.Join("", n.ToString().OrderByDescending(c => c));
        
        return Convert.ToInt64(str);
    }
}