using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) => (int)Regex.Replace(my_string, @"[^0-9]", "").Sum(c => char.GetNumericValue(c));
}