using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e)
    {
        var subString = my_string.Substring(s, e-s + 1);
        var reversed = string.Join("", subString.Reverse());
        return my_string.Replace(subString, reversed);
    }
}