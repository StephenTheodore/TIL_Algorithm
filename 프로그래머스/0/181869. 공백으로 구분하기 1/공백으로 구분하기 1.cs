using System;
using System.Linq;

public class Solution {
    public string[] solution(string my_string) => my_string.Trim().Split(' ').Where(str => str.Length > 0).ToArray();
}