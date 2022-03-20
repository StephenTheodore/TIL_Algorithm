/*
◆ 문제 설명
효진이는 멀리 뛰기를 연습하고 있습니다. 효진이는 한번에 1칸, 또는 2칸을 뛸 수 있습니다. 칸이 총 4개 있을 때
(1칸, 1칸, 1칸, 1칸)
(1칸, 2칸, 1칸)
(1칸, 1칸, 2칸)
(2칸, 1칸, 1칸)
(2칸, 2칸)
다음과 같은 경우의 수로 움직일 수 있습니다.

효진이가 끝에 도달하는 방법이 몇 가지인지 알아내, 여기에 1234567를 나눈 나머지를 반환하세요.

◆ 매개변수
  n : 멀리뛰기에 사용될 칸의 수

◆ 제한 사항
  n은 1 이상, 2000 이하인 정수입니다.
*/

public class Solution {
    public long solution(int n)
    {
        long next = 0;
        long pre = 1;
        long cur = 2;

        if(n < 3)
            return n;
        for (int i = 3; i <= n; i++)
        {
            next = pre + cur;
            pre = cur;
            cur = next % 1234567;
        }

        return next % 1234567;
    }
}