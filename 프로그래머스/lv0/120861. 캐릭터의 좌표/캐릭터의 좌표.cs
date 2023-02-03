using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board)
    {
        int[] limit = new int[2] { (board[0]/2)+1, (board[1]/2)+1 };
        int[] coord = new int[2];
        
        for(int i = 0; i < keyinput.Length; i++)
        {
            switch (keyinput[i])
            {
                case "up":
                    if (limit[1] > coord[1] + 1) coord[1]++;
                    break;
                case "down":
                    if (-limit[1] < coord[1] - 1) coord[1]--;
                    break;
                case "left":
                    if (-limit[0] < coord[0] - 1) coord[0]--;
                    break;
                case "right":
                    if (limit[0] > coord[0] + 1) coord[0]++;
                    break;
            }
        }
        
        return coord;
    }
}