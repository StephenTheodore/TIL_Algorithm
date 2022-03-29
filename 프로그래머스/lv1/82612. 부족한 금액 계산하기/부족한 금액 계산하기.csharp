using System;

class Solution
{
    public long solution(long price, long money, long count)
    {
        long fee;
        long pCnt = 1;
        long pLek = 0;
        while(pCnt <= count)
        {
            fee = price * pCnt;
            if(money - fee < 0)
            {
                pLek += (fee - money);
                pCnt++;
                break;
            }
            money -= fee;
            pCnt++;
        }
        while(pCnt <= count)
        {
            fee = price * pCnt;
            pLek += fee;
            pCnt++;
        }
        return pLek;
    }
}