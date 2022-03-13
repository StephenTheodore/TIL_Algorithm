/*
◆ 문제설명
이중 우선순위 큐는 다음 연산을 할 수 있는 자료구조를 말합니다.

명령어       수신 탑(높이)
I 숫자       큐에 주어진 숫자를 삽입합니다.
D 1         큐에서 최댓값을 삭제합니다.
D -1        큐에서 최솟값을 삭제합니다.

주어진 명령들에 대해 모든 연산을 처리한 후 큐가 비어있으면 [0,0] 비어있지 않으면 [최댓값, 최솟값]을 반환하세요.

◆ 매개변수
  operations : 이중 우선순위 큐가 할 연산들

◆ 제한사항
  operations는 길이가 1 이상 1,000,000 이하인 문자열 배열입니다.
  operations의 원소는 큐가 수행할 연산을 나타냅니다.
  원소는 “명령어 데이터” 형식으로 주어집니다.- 최댓값/최솟값을 삭제하는 연산에서 최댓값/최솟값이 둘 이상인 경우, 하나만 삭제합니다.
  빈 큐에 데이터를 삭제하라는 연산이 주어질 경우, 해당 연산은 무시합니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] operations)
    {
        List<int> list = new List<int>();   //Queue를 사용해야 하는 것 같지만 쉬운방법을 선택했다.

        for (int i = 0; i < operations.Length; i++)
        {
            string opr = operations[i].Split(' ')[0];
            int num = Convert.ToInt32(operations[i].Split(' ')[1]);

            if (opr == "I")
                list.Add(num);
            else if(list.Count != 0)
            {
                if (num == 1)
                    list.Remove(list.Max());
                else
                    list.Remove(list.Min());
            }
        }
        if (list.Count != 0)
            return new int[2] { list.Max(), list.Min() };
        return new int[2] { 0, 0 };
    }
}