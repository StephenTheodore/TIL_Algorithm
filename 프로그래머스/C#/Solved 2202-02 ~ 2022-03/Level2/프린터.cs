/*
◆ 문제설명
일반적인 프린터는 인쇄 요청이 들어온 순서대로 인쇄하기 때문에 중요한 문서가 나중에 인쇄될 수 있습니다.
이런 문제를 보완하기 위해 중요도가 높은 문서를 먼저 인쇄하는 프린터를 개발했습니다.

이 새롭게 개발한 프린터는 아래와 같은 방식으로 인쇄 작업을 수행합니다.
  1. 인쇄 대기목록의 가장 앞에 있는 문서(J)를 대기목록에서 꺼냅니다.
  2. 나머지 인쇄 대기목록에서 J보다 중요도가 높은 문서가 한 개라도 존재하면 J를 대기목록의 가장 마지막에 넣습니다.
  3. 그렇지 않으면 J를 인쇄합니다.

예를 들어, 4개의 문서(A, B, C, D)가 순서대로 인쇄 대기목록에 있을 때
중요도가 2 1 3 2 라면 C D A B 순으로 인쇄하게 됩니다.
내가 인쇄를 요청한 문서가 몇 번째로 인쇄되는지 알고 싶습니다. 위의 예에서 C는 1번째로, A는 3번째로 인쇄됩니다.

◆ 매개변수
  priorities : 현재 대기목록에 있는 문서의 중요도가 순서대로 담긴 배열
  location : 내가 인쇄를 요청한 문서의 현재 대기목록에서의 위치

◆ 제한사항
  현재 대기목록에는 1개 이상 100개 이하의 문서가 있습니다.
  인쇄 작업의 중요도는 1~9로 표현하며 숫자가 클수록 중요하다는 뜻입니다.
  location은 0 이상 (현재 대기목록에 있는 작업 수 - 1) 이하의 값을 가지며 대기목록의 가장 앞에 있으면 0, 두 번째에 있으면 1로 표현합니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        int max = 0;
        int target = 0;
        List<int> listPrint = new List<int>();
        List<bool> listBoolean = new List<bool>();

        for (int i = 0; i < priorities.Length; i++ )
        {
            listPrint.Add(priorities[i]);
            if (location != i)
                listBoolean.Add(false);
            else
                listBoolean.Add(true);
        }

        target = listPrint.ElementAt(location);
        while(true)
        {
            max = listPrint.Max();
            int count = listPrint.Count;
            for (int i = 0; i < count; i++)
            {
                if (max == target && listBoolean.ElementAt(0) == true)
                {
                    return answer + 1;
                }
                if (listPrint.ElementAt(0) == max)
                {
                    listPrint.RemoveAt(0);
                    listBoolean.RemoveAt(0);
                    answer++;
                    if (!listPrint.Contains(max))
                        break;
                }
                else
                {
                    listPrint.Add(listPrint.ElementAt(0));
                    listPrint.RemoveAt(0);
                    listBoolean.Add(listBoolean.ElementAt(0));
                    listBoolean.RemoveAt(0);
                }
            }
        }
    }
}