using System;

public class Solution {
    public int solution(int[] num_list) 
    {
        int evenSum = 0;
        int oddSum = 0;
        for (int index = 0; index < num_list.Length; index++)
        {
            if (index % 2 == 0)
                evenSum += num_list[index];
            else
                oddSum += num_list[index];
        }
        
        return Math.Max(evenSum, oddSum);
    }
}