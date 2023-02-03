using System.Text;

public class Solution {
    public string solution(string s) 
    {
        var sb = new StringBuilder();
        
        foreach(var str in s.Split(' '))
        {
            for(int i = 0; i < str.Length; i++)
                sb.Append(i%2 == 0 ? char.ToUpper(str[i]) : char.ToLower(str[i]));
            sb.Append(" ");
        }
        
        return sb.ToString().Substring(0, sb.Length-1);
    }
}