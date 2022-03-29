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