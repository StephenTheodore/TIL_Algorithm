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