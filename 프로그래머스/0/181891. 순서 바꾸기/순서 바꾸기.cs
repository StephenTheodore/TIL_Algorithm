using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] list, int n) => list.Skip(n).Concat(list.Take(n)).ToArray();
}