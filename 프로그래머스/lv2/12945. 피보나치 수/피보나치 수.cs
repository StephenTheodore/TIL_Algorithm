public class Solution {
    public int solution(int n) {
        int answer = 0;
        int pre = 1;
        int ppre = 0;
        for(int i=1; i<n; i++)
        {
            answer = pre + ppre;
            answer = answer%1234567;
            ppre = pre;
            pre = answer;
        }
        answer = answer%1234567;
        return answer;
    }
}