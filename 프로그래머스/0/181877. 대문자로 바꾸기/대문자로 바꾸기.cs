using System;
using System.Linq;

public class Solution {
    public string solution(string myString) => string.Join("", myString.Select(ch => char.ToUpper(ch)));
}