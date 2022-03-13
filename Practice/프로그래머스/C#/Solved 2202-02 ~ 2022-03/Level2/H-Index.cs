/*
◆ 문제설명
H-Index는 과학자의 생산성과 영향력을 나타내는 지표입니다. 어느 과학자의 H-Index를 나타내는 값인 h를 구하려고 합니다.

H-Index는 다음과 같이 구합니다.
어떤 과학자가 발표한 논문 n편 중, h번 이상 인용된 논문이 h편 이상이고 나머지 논문이 h번 이하 인용되었다면 h의 최댓값이 이 과학자의 H-Index입니다.

◆ 매개변수
  citations : 어떤 과학자가 발표한 논문의 인용 횟수를 담은 배열

◆ 제한사항
  과학자가 발표한 논문의 수는 1편 이상 1,000편 이하입니다.
  논문별 인용 횟수는 0회 이상 10,000회 이하입니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] citations)
    {
        int H = 0;
        List<int> list = new List<int>(citations);
        list.Sort((a, b) => b.CompareTo(a));
        foreach(int n in list)
        {
            if (n == ++H)
                break;                    
            if (H > n)
            {
                H--;
                break;
            }
        }
        return H;
    }
}