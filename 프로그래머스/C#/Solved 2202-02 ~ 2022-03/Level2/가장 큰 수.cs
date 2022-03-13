/*
◆ 문제설명
0 또는 양의 정수가 주어졌을 때, 정수를 이어 붙여 만들 수 있는 가장 큰 수를 알아내 주세요.

예를 들어, 주어진 정수가 [6, 10, 2]일 때
  1. 조합 순서를 바꿔가면서 [6102, 6210, 1062, 1026, 2610, 2106]를 만들 수 있습니다.
  2. 1번의 조합된 숫자 중 가장 큰 수는 6210입니다.

◆ 매개변수
  numbers : 0 또는 양의 정수가 담긴 배열

◆ 제한사항
  numbers의 길이는 1 이상 100,000 이하입니다.
  numbers의 원소는 0 이상 1,000 이하입니다.
  정답이 너무 클 수 있으니 문자열로 바꾸어 return 합니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(int[] numbers)
    {
        if (numbers.Max() == 0)
            return "0";
        Array.Sort(numbers, (a, b) => (b.ToString() + a.ToString()).CompareTo(a.ToString() + b.ToString()));

        return string.Join("", numbers);    //string.Join() 문자열을 일일이 붙이는 것과 속도차이가 어마어마하다. 이걸 몰라서 최적화 하는데 2시간 넘게 헤멨다...
    }
}