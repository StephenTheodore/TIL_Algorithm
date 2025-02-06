using System;

public class Solution {
    public int solution(int[] arr)
    {
        int count = 0;
        bool isChanged;
        do
        {
            isChanged = false;
            for (int index = 0; index < arr.Length; index++)
            {
                int prev = arr[index];
                if (prev >= 50 && prev % 2 == 0)
                    arr[index] /= 2;
                else if (prev < 50 && prev % 2 == 1)
                    arr[index] = prev * 2 + 1;
                
                if (prev != arr[index])
                    isChanged = true;
            }
            
            if (isChanged)
                count++;
            
        } while(isChanged);
        
        return count;
    }
}