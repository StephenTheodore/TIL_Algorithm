using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(int[] numbers)
    {
        if (numbers.Max() == 0)
            return "0";
        Array.Sort(numbers, (a, b) => (b.ToString() + a.ToString()).CompareTo(a.ToString() + b.ToString()));

        return string.Join("", numbers);
    }
}