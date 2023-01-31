using System;
using System.Linq;

public class Solution {
    public string solution(string s) => 
        string.Join("", s.GroupBy(c => c).Where(g => g.Count() == 1).Select(g => g.Key).OrderBy(c => c));
}