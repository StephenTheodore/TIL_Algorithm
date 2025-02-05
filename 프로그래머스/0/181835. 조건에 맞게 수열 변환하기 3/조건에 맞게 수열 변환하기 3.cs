using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k)
    {
        bool isOddK = k % 2 == 1;
        return arr.Select(num => isOddK ? num * k : num + k).ToArray();
    }
}