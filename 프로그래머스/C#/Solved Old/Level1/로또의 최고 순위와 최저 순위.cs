using System;
using System.IO;
using System.Text;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int maxcnt = 0, mincnt = 0;
        
        for(int i = 0; i < 6; i++)
        {
            if(lottos[i] == 0)
            {
                maxcnt++;
                continue;
            }
            for(int j = 0; j < 6; j++)
            {
                if(lottos[i] == win_nums[j])
                {
                    maxcnt++;
                    mincnt++;
                }
            }
        }
        
        if(maxcnt != 0)
            answer[0] = (6 - maxcnt) + 1;
        else
            answer[0] = 6;
        if(mincnt != 0)
            answer[1] = (6 - mincnt) + 1;
        else
            answer[1] = 6;
        return answer;
    }
}