using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        var sb = new StringBuilder("0");
        for (int index = food.Length - 1; index >= 1; index--)
        {
            var foodCount = food[index] / 2;
            while (foodCount-- > 0)
            {
                sb.Insert(0, index);
                sb.Append(index);
            }
        }
        
        return $"{sb}";
    }
}