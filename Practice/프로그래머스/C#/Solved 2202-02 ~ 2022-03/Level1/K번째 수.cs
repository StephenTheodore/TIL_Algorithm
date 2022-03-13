/*
◆ 문제설명
배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.

예를 들어 array가 [1, 5, 2, 6, 3, 7, 4], i = 2, j = 5, k = 3이라면
  1. array의 2번째부터 5번째까지 자르면 [5, 2, 6, 3]입니다.
  2. 1에서 나온 배열을 정렬하면 [2, 3, 5, 6]입니다.
  3. 2에서 나온 배열의 3번째 숫자는 5입니다.

◆ 매개변수
  array : 숫자가 들어있는 배열
  commands : [i, j, k]를 원소로 가진 2차원 배열

◆ 제한사항
  array의 길이는 1 이상 100 이하입니다.
  array의 각 원소는 1 이상 100 이하입니다.
  commands의 길이는 1 이상 50 이하입니다.
  commands의 각 원소는 길이가 3입니다.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            answer[i] = findK(array, commands[i, 0], commands[i, 1], commands[i, 2]);
        }

        return answer;
    }
    public int findK(int[] array, int i, int j, int k)
    {
        List<int> list = new List<int>();
        for (i = i-1; i < j; i++)
        {
            list.Add(array[i]);
        }
        list.Sort();
                
        return list.ElementAt(k-1);
    }
}