using System;
using System.Linq;

public class Solution {
    public int solution(int n) => (int)n.ToString().ToList().Sum(c => char.GetNumericValue(c));
}