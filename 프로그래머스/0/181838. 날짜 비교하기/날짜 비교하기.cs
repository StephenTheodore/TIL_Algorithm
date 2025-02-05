using System;

public class Solution {
    public int solution(int[] date1, int[] date2) => date1[0] * 365 + date1[1] * 31 + date1[2] < date2[0] * 365 + date2[1] * 31 + date2[2] ? 1 : 0;
}