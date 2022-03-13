/*
◆ 문제설명
네트워크란 컴퓨터 상호 간에 정보를 교환할 수 있도록 연결된 형태를 의미합니다.

예를 들어, 컴퓨터 A와 컴퓨터 B가 직접적으로 연결되어있고, 컴퓨터 B와 컴퓨터 C가 직접적으로 연결되어 있을 때
컴퓨터 A와 컴퓨터 C도 간접적으로 연결되어 정보를 교환할 수 있습니다. 
따라서 컴퓨터 A, B, C는 모두 같은 네트워크 상에 있다고 할 수 있습니다.
주어진 값에 대한 네트워크의 개수를 구하세요.

◆ 매개변수
  n : 컴퓨터의 개수
  computers : 연결에 대한 정보가 담긴 2차원 배열

◆ 제한사항
  컴퓨터의 개수 n은 1 이상 200 이하인 자연수입니다.
  각 컴퓨터는 0부터 n-1인 정수로 표현합니다.
  i번 컴퓨터와 j번 컴퓨터가 연결되어 있으면 computers[i][j]를 1로 표현합니다.
  computer[i][i]는 항상 1입니다.
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    int amountComputers;
    int amountNetworks = 0;
    public int solution(int n, int[,] computers)
    {
        List<int> listIndex;
        this.amountComputers = n;

        for(int i = 0; i<computers.GetLength(0); i++)
        {
            listIndex = new List<int>();
            if (computers[i, i] == 1)
            {
                listIndex.Add(i);
                findNetworks(ref computers, listIndex);
                amountNetworks++;
            }
        }

        return amountNetworks;
    }
    public void findNetworks(ref int[,] computers, List<int> listIndex)
    {
        int index = listIndex.Last();
        if (computers[index, index] == 0)
            return;
        for (int i = 0; i < computers.GetLength(0); i++)
        {
            if (index == i)
                computers[index, index] = 0;
            else if (computers[index, i] == 1)
            {
                computers[index, i] = 0;
                listIndex.Add(i);
                findNetworks(ref computers, listIndex);
            }
        }
    }
}