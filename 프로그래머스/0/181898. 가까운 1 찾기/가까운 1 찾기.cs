using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr, int idx) => arr.ToList().FindIndex(idx, elem => elem == 1);
}