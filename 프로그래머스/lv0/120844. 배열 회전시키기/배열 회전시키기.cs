using System;

public class Solution {
    public int[] solution(int[] numbers, string direction)
    {
        int[] result = new int[numbers.Length];
        int shift;
        int length = numbers.Length;
        
        if(direction == "right")
        {
            shift = numbers[length - 1];
            Array.Copy(numbers, 0, result, 1, length - 1);
            result[0] = shift;
        }
        else
        {
            shift = numbers[0];
            Array.Copy(numbers, 1, result, 0, length - 1);
            result[length - 1] = shift;
        }
        
        return result;
    }
}