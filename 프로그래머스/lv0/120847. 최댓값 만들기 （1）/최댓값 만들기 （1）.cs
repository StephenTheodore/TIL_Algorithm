using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        var numList = numbers.OrderByDescending(n => n);
        return numList.ElementAt(0) * numList.ElementAt(1);
    }
}