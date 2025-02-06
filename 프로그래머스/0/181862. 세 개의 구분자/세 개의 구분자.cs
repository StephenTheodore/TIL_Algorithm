using System;
using System.Linq;

public class Solution {
    public string[] solution(string myStr)
    {
        var result = myStr.Split(new char[]{'a','b','c'}).Where(str => str.Length > 0).ToArray();
        return result.Length > 0 ? result : new string[]{"EMPTY"};
    }
}