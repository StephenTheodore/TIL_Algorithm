using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list, int n) => num_list.Skip(n - 1).ToArray();
}