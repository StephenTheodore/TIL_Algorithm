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