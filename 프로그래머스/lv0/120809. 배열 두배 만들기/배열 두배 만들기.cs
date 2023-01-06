using System;

public class Solution {
    public int[] solution(int[] numbers) {
        for(int index = 0; index < numbers.Length; index++)
            numbers[index] *= 2;
        return numbers;
    }
}