using System;

public class Solution {
    public int solution(int[] numbers, int n) 
    {
        int sum = 0;
        for (int index = 0; index < numbers.Length && sum <= n; index++)
            sum += numbers[index];
        return sum;
    }
}