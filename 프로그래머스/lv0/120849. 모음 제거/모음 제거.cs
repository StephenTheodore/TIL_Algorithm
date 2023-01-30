using System;
using System.Text.RegularExpressions;

public class Solution {
    public string solution(string my_string) => Regex.Replace(my_string, @"[aeiou]", "");
}