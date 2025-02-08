using System;

public class Solution {
    public int solution(int a, int b) {
        double div = (double)a / b / Math.Pow(10,50);
        return $"{div}".Length >= 16 ? 2 : 1;
    }
}