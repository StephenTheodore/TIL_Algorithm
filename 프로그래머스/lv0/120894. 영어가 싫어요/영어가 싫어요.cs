using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution {
    public long solution(string numbers)
    {
        var dict = new Dictionary<string,string>
        {
            {"zero", "0"},
            {"one", "1"},
            {"two", "2"},
            {"three", "3"},
            {"four", "4"},
            {"five", "5"},
            {"six", "6"},
            {"seven", "7"},
            {"eight", "8"},
            {"nine", "9"},
        };
        
        foreach(var pair in dict)
            numbers = numbers.Replace(pair.Key, pair.Value);
        
        return Convert.ToInt64(numbers);
    }
}