class Solution {
    public String solution(int n) {
        String answer = "";
        boolean isSu = true;
        
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