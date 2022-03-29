public class Solution {
    public long solution(long num) {
        long answer = 0;
        if(num == 1)
            return answer;
        while(answer < 500)
        {
            answer++;
            if(num%2==0)
                num = num/2;
            else
                num = (num*3)+1;
            if(num == 1)
                return answer;
        }
        return -1;
    }
}