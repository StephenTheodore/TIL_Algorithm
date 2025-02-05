using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int n)
    {
        bool isAddToEven = arr.Length % 2 == 1;
        
        for (int index = 0; index < arr.Length; index++)
        {
            if (isAddToEven && index % 2 == 0)
                arr[index] += n;
            else if (!isAddToEven && index % 2 == 1)
                arr[index] += n;
        }
        return arr;
    }
}