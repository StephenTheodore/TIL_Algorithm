using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numlist, int n) => numlist.OrderBy(v => Math.Abs(n-v)).ThenByDescending(v => v).ToArray();
}