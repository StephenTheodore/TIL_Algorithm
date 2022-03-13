/*
◆ 문제설명
초 단위로 기록된 주식가격이 담긴 배열이 주어질 때 가격이 떨어지지 않은 기간은 몇 초인지 구하시오.

◆ 매개변수
  prices : 초 단위로 기록된 주식가격이 담긴 배열

◆ 제한사항
  prices의 각 가격은 1 이상 10,000 이하인 자연수입니다.
  prices의 길이는 2 이상 100,000 이하입니다.
*/

using System;

public class Solution
{
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
        {
            answer[i] = Cal_time(prices[i], prices, i+1);
        }

        return answer;
    }
    private static int Cal_time(int Cur_price, int[] prices, int sec)
    {
        int time = 0;
        for (int i = sec; i < prices.Length; i++)
        {
            ++time;
            if (Cur_price > prices[i])
                break;
        }
        return time;
    }
}