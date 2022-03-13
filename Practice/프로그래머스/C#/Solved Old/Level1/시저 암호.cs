using System;
using System.Text;

public class Solution {
            public string solution(string s, int n)
        {
            StringBuilder answer = new StringBuilder();
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if(c[i] == 32)
                {
                    answer.Append(" ");
                    continue;   
                }
                if (c[i] >= 97)
                {
                    c[i] = (char)((c[i] - 97 + n) % 26);
                    c[i] += (char)97;
                }
                else
                {
                    c[i] = (char)((c[i] - 65 + n) % 26);
                    c[i] += (char)65;
                }
                answer.Append(c[i]);
            }

            return answer.ToString();
        }
}