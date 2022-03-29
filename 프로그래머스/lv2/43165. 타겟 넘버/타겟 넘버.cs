using System;

public class Solution {
        int target;
        int count = 0;
        public int solution(int[] numbers, int target)
        {
            this.target = target;
            foundCases(numbers);

            return count;
        }
        public void foundCases(int[] numbers)
        {
            prefixMinus(numbers, 0, 0);
            prefixPlus(numbers, 0, 0);
        }
        public void prefixMinus(int[] numbers, int number, int index)
        {
            int sum = number - numbers[index++];
            if (numbers.Length == index)
            {
                if (sum == target)
                    count++;
                return;
            }
            prefixMinus(numbers, sum, index);
            prefixPlus(numbers, sum, index);
        }
        public void prefixPlus(int[] numbers, int number, int index)
        {
            int sum = number + numbers[index++];
            if (numbers.Length == index)
            {
                if (sum == target)
                    count++;
                return;
            }
            prefixMinus(numbers, sum, index);
            prefixPlus(numbers, sum, index);
        }
}