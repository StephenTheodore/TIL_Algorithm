using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        String[] Strings = s.Split();
        Char[] Text;
        for (int i = 0; i < Strings.Length; i++)
        {
            Text = Strings[i].ToLower().ToCharArray();
            if (i != Strings.Length - 1)
            {
                if (Text.Length == 0)
                {
                    answer.Append(" ");
                    continue;
                }
                Text[0] = Char.ToUpper(Text[0]);
                answer.Append(String.Concat(Text));
                answer.Append(" ");

            }
            else
            {
                if (Text.Length == 0)
                    break;
                Text[0] = Char.ToUpper(Text[0]);
                answer.Append(String.Concat(Text));
            }
        }
        return answer.ToString();
    }
}