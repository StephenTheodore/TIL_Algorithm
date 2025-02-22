using System;

public class Solution {
    public int solution(int[,] dots)
    {
        int minX = int.MaxValue, minY = int.MaxValue;
        int maxX = int.MinValue, maxY = int.MinValue;
        
        for (int index = 0; index < dots.GetLength(0); index++)
        {   
            int x = dots[index, 0];
            int y = dots[index, 1];
            
            minX = Math.Min(x, minX);
            minY = Math.Min(y, minY);
            maxX = Math.Max(x, maxX);
            maxY = Math.Max(y, maxY);
        }
        
        int width = maxX - minX;
        int height = maxY - minY;
        return width * height;
    }
}