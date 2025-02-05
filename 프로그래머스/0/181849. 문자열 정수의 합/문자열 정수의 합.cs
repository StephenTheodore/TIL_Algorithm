using System;
using System.Linq;

public class Solution {
    public int solution(string num_str) => num_str.Sum(ch => (int)char.GetNumericValue(ch));
}