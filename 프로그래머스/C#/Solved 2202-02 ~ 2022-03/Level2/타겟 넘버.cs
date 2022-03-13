/*
◆ 문제설명
n개의 음이 아닌 정수들이 있습니다. 이 정수들을 순서를 바꾸지 않고 적절히 더하거나 빼서 타겟 넘버를 만들려고 합니다.
예를 들어 [1, 1, 1, 1, 1]로 숫자 3을 만들려면 다음 다섯 방법을 쓸 수 있습니다.
    1 =>  -1+1+1+1+1 = 3
    2 =>  +1-1+1+1+1 = 3
    3 =>  +1+1-1+1+1 = 3
    4 =>  +1+1+1-1+1 = 3
    5 =>  +1+1+1+1-1 = 3

◆ 매개변수
  numbers : 사용할 수 있는 숫자가 담긴 배열
  target : 타겟 넘버

◆ 제한사항
  타겟 넘버는 1 이상 1000 이하인 자연수입니다.
  주어지는 숫자의 개수는 2개 이상 20개 이하입니다.
  각 숫자는 1 이상 50 이하인 자연수입니다.
*/

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