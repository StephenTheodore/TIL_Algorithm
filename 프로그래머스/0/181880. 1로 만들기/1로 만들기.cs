using System;

public class Solution {
    public int solution(int[] num_list) 
    {
        int count = 0;
        for (int index = 0; index < num_list.Length; index++)
        {
            int num = num_list[index];
            while (num > 1)
            {
                if (num % 2 == 1)
                    num--;
                num /= 2;
                count++;
            }
        }
        return count;
    }
}