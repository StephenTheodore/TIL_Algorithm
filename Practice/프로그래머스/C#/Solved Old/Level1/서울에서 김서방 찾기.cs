public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        
        foreach(int i in seoul.Length)
        {
            if(seoul[i] == "Kim")
            {
                answer = "김서방은 "+i+"에 있다";
                break;
            }
        }
        
        return answer;
    }
}