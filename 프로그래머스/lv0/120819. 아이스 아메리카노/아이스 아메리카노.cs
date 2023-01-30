using System;

public class Solution {
    const int coffee = 5500;
    public int[] solution(int money) => new int[] { money / coffee , money % coffee };
}