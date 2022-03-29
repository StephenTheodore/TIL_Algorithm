using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] operations)
    {
        List<int> list = new List<int>();

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