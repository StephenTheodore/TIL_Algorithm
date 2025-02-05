using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) => strArr.Where(str => !str.Contains("ad")).ToArray();
}