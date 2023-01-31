using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers)
    {
        var list = numbers.OrderBy(n => n).ToList();
        
        return Math.Max((list[0] * list[1]), (list[list.Count - 1] * list[list.Count - 2]));
    }
}