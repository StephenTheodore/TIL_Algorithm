using System;

public class Solution {
    public string solution(string my_string, int n) => my_string.Substring(my_string.Length - n, n);
}