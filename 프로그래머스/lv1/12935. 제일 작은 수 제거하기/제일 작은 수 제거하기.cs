using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        int min;
        int cnt=1;
        int sub=0;
        if(arr.Length == 1)
            return new int[] {-1};
        else
        {
            min = arr[0];
            for(int i = 1; i<arr.Length; i++)
            {
                if(min == arr[i])
                    cnt++;
                if(min > arr[i])
                {
                    cnt = 1;
                    min = arr[i];
                }
            }
            answer = new int[arr.Length-cnt];
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i]==min)
                    sub++;
                else
                    answer[i-sub] = arr[i];
            }
            Console.WriteLine(cnt);
        }
        return answer;
    }
}