using System;

public class Solution {
    public int solution(string s)
    {
        int sum = 0;
        int lastNum = 0;
        foreach (var str in s.Split(' '))
        {
            if (str != "Z")
                sum += lastNum = Convert.ToInt32(str);
            else
                sum -= lastNum;
        }
        return sum;
    }
}