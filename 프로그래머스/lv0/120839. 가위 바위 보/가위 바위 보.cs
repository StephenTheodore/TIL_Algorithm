using System;
using System.Text;

public class Solution {
    public string solution(string rsp)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach(var ch in rsp)
        {
            int @value = (int)char.GetNumericValue(ch);
            if(value == 2)
                sb.Append("0");
            else if(value == 0)
                sb.Append("5");
            else
                sb.Append("2");
        }
        
        return sb.ToString();
    }
}