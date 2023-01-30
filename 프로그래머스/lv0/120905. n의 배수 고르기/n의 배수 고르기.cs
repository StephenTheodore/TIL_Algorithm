using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[] numlist) => numlist.Where(num => num%n == 0).ToArray();
}