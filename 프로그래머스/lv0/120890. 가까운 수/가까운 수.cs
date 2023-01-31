using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) =>
        array.Distinct().ToDictionary(e => e, e => Math.Abs(e - n)).OrderBy(e => e.Value).ThenBy(e => e.Key).First().Key;
}