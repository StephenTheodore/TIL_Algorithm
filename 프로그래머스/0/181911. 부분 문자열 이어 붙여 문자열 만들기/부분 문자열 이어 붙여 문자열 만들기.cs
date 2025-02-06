using System;
using System.Text;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        var sb = new StringBuilder();
        for (int index = 0; index < my_strings.Length; index++)
            sb.Append(my_strings[index].Substring(parts[index, 0], parts[index, 1]-parts[index, 0] + 1));
        
        return $"{sb}";
    }
}