using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) =>
        Regex.Replace(my_string, @"[^0-9]", "|").Split('|').Where(s => s != "").Sum(s => Convert.ToInt32(s));
}