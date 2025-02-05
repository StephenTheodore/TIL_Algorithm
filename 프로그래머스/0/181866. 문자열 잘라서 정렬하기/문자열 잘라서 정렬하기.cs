using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) => myString.Split('x').Where(str => str.Length > 0).OrderBy(str => str).ToArray();
}