using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        var result = new List<string>();
        var sb = new StringBuilder();
        
        foreach (string row in picture)
        {
            sb.Clear();
            foreach (char pixel in row)
            {
                int scaleCols = k;
                while (scaleCols-- > 0)
                    sb.Append(pixel);
            }
            
            int scaleRows = k;
            while (scaleRows-- > 0)
                result.Add($"{sb}");
        }
        
        return result.ToArray();
    }
}