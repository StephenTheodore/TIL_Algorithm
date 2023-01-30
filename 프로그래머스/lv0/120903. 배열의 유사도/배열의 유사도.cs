using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) => s1.Intersect(s2).Count();
}