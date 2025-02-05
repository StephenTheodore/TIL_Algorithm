using System;
using System.Linq;

public class Solution {
    public string solution(string[] str_list, string ex) => string.Concat(str_list.Where(str => !str.Contains(ex)));
}