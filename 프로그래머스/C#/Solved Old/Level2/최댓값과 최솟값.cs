/*
◆ 문제설명
문자열 s에는 공백으로 구분된 숫자들이 저장되어 있습니다. str에 나타나는 숫자 중 최소값과 최대값을 찾아 이를 "(최소값) (최대값)"형태의 문자열을 반환하는 함수, solution을 완성하세요.
예를들어 s가 "1 2 3 4"라면 "1 4"를 리턴하고, "-1 -2 -3 -4"라면 "-4 -1"을 리턴하면 됩니다.

◆ 제한조건
  s에는 둘 이상의 정수가 공백으로 구분되어 있습니다.
*/
using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        String[] Strs = s.Split();
        int max = int.Parse(Strs[0]);
        int min = int.Parse(Strs[0]);

        for(int i = 1; i < Strs.Length; i++)
        {
            if(int.Parse(Strs[i]) > max)
                max = int.Parse(Strs[i]);
            if(min > int.Parse(Strs[i]))
                min = int.Parse(Strs[i]);
        }
        answer.Append(min.ToString() + " ");
        answer.Append(max.ToString());

        return answer.ToString();
    }
}