using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2)
    {
        List<int> ret = new List<int>();
        for(int index = num1; index <= num2; index++)
            ret.Add(numbers[index]);
        return ret.ToArray();
    }
}