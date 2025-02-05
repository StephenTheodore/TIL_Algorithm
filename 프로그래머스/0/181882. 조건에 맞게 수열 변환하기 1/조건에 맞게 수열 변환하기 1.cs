using System;

public class Solution {
    public int[] solution(int[] arr) 
    {
        for (int index = 0; index < arr.Length; index++)
        {
            var elem = arr[index];
            if (elem >= 50 && elem % 2 == 0)
                arr[index] /= 2;
            else if (elem < 50 && elem % 2 == 1)
                arr[index] *= 2;
        }
        
        return arr;
    }
}