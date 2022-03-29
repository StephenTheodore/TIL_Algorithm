using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] p1 = new int[5] {1,2,3,4,5};
        int[] p2 = new int[8] {2,1,2,3,2,4,2,5};
        int[] p3 = new int[10] {3,3,1,1,2,2,4,4,5,5};
        int[] cnt = new int[3] {0,0,0};
        int i,max=0;
        for(i=0; i<answers.Length; i++)
        {
            if(answers[i] == p1[i%5])
                cnt[0]++;
            if(answers[i] == p2[i%8])
                cnt[1]++;
            if(answers[i] == p3[i%10])
                cnt[2]++;
        }
        for(i=0; i<3; i++)
        {
            if(cnt[i] > max)
                max = cnt[i];
        }
        for(i=0; i<3; i++)
        {
            if(max == cnt[i])
                answer.Add(i+1);
        }
        return answer.ToArray();
    }
}