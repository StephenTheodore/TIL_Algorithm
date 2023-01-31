using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) => string.Join("", my_string.ToLower().OrderBy(c => c));
}