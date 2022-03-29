using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 0;

            Dictionary<string, int> dicClothes = new Dictionary<string, int>();
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (dicClothes.ContainsKey(clothes[i, 1]))
                {
                    dicClothes[clothes[i, 1]]++;
                }
                else
                {
                    dicClothes.Add(clothes[i, 1], 2);
                }
            }
            for (int i = 0; i < dicClothes.Values.Count; i++)
            {
                if (i == 0)
                    answer = dicClothes.Values.ElementAt(i);
                else
                    answer *= dicClothes.Values.ElementAt(i);
            }

            return answer - 1;
    }
}