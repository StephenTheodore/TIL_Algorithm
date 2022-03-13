/*
◆ 문제 설명
프로그래머스 팀에서는 기능 개선 작업을 수행 중입니다. 각 기능은 진도가 100%일 때 서비스에 반영할 수 있습니다.
또, 각 기능의 개발속도는 모두 다르기 때문에 뒤에 있는 기능이 앞에 있는 기능보다 먼저 개발될 수 있고, 이때 뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포됩니다.

◆ 매개 변수
  progresses : 먼저 배포되어야 하는 순서대로 작업의 진도가 적힌 정수 배열
  speeds : 작업의 개발 속도가 적힌 정수 배열

◆ 제한 사항
  작업의 개수(progresses, speeds배열의 길이)는 100개 이하입니다.
  작업 진도는 100 미만의 자연수입니다.
  작업 속도는 100 이하의 자연수입니다.
  배포는 하루에 한 번만 할 수 있으며, 하루의 끝에 이루어진다고 가정합니다. 예를 들어 진도율이 95%인 작업의 개발 속도가 하루에 4%라면 배포는 2일 뒤에 이루어집니다.
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new List<int>();
        bool[] comp = new bool[progresses.Length+1];
        int cnt=0;
        int i,j;
        int pub = 0;
        int index = 0;
        
        
        while(pub < progresses.Length)
        {
            for(i=0; i<progresses.Length; i++)
            {
                progresses[i] += speeds[i];
                if(progresses[i] >= 100)
                {
                    comp[i] = true;
                }

            }
            while(comp[pub] == true)
            {
                pub++;
                cnt++;
            }
            if(cnt!=0)
            {
                answer.Add(cnt);
                cnt = 0;
            }
        }
        return answer.ToArray();
    }
}