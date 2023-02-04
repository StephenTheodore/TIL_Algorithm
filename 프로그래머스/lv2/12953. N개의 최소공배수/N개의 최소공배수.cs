using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr)
    {
        int num = arr.Min();
        
        while(arr.Any(n => num % n != 0))
            num++;
        
        return num;
    }
}