using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int N, int number)
    {
        CalcResult[] results = new CalcResult[8];
        string initString = "";

        results[0] = new CalcResult(N.ToString());

        if (N == number)
            return 1;

        for (int i = 1; i < 8; i++)
        {
            initString += N.ToString();
            results[i] = new CalcResult(initString);
            for (int j = 0; j < i; j++)
                results[i].AddNumbers(results[i - j - 1].GetList());
            if (results[i].IsExist(number))
                return i + 1;
        }

        return -1;
    }
    public class CalcResult
    {
        private string number;
        private List<int> list = new List<int>();
        public CalcResult(string number)
        {
            this.number = number;
            list.Add(Convert.ToInt32(number));
        }
        public void AddNumbers(List<int> values)
        {
            foreach(int val1 in list)
            {
                foreach (int val2 in values)
                {
                    list.Add(val1 + val2);
                    list.Add(val1 * val2);
                    if (val1 - val2 > 0)
                        list.Add(val1 - val2);
                    if (val2 - val1 > 0)
                        list.Add(val2 - val1);
                    if (val1 != 0 && val2 != 0)
                        if (val1 > val2)
                            list.Add(val1 / val2);
                        else
                            list.Add(val2 / val1);
                }
                return;
            }
        }
        public List<int> GetList()
        {
            list.Add(Convert.ToInt32(number + number[0]));
            return list;
        }
        public bool IsExist(int value)
        {
            return list.Contains(value);
        }
    }
}