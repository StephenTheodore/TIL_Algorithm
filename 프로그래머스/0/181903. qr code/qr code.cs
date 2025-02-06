using System;
using System.Text;

public class Solution {
    public string solution(int q, int r, string code)
    {
        var sb = new StringBuilder();
        for (int index = 0; index < code.Length; index++)
        {
            if (index % q == r)
                sb.Append(code[index]);
        }
        return $"{sb}";
    }
}