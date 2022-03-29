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