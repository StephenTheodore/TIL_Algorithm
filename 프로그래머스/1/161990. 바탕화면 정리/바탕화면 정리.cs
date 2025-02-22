using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        // 왜 xy임
        int lux = int.MaxValue, luy = int.MaxValue;
        int rdx = int.MinValue, rdy = int.MinValue;
        
        for (int row = 0; row < wallpaper.Length; row++)
        {
            string gridRow = wallpaper[row];
            for (int col = 0; col < gridRow.Length; col++)
            {
                if (gridRow[col] == '#')
                {
                    lux = Math.Min(lux, row);
                    luy = Math.Min(luy, col);
                    rdx = Math.Max(rdx, row + 1);
                    rdy = Math.Max(rdy, col + 1);
                }
            }
        }
        
        return new int[] {lux, luy, rdx, rdy};
    }
}