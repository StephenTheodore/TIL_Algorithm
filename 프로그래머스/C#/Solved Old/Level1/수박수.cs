public class Solution {
    public string solution(int n) {
        string answer = "";
        bool isSu = true;
        
        for(int i=0; i<n; i++)
        {
            if(isSu)
                answer += "수";
            else
                answer += "박";
            isSu = isSu ? false : true;
        }
        
        return answer;
    }
}