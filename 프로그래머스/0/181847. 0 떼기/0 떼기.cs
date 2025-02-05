using System;
using System.Linq;

public class Solution {
    public string solution(string n_str) => string.Join("", n_str.SkipWhile(ch => ch == '0'));
}