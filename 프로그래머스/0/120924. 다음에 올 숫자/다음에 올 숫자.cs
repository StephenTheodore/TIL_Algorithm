using System;

public class Solution {
    public int solution(int[] common) {
        bool isArithmetic = common[1] - common[0] == common[2] - common[1];
        if (isArithmetic)
            return common[common.Length - 1] + (common[1] - common[0]);
        else
            return common[common.Length - 1] * (common[1] / common[0]);
    }
}