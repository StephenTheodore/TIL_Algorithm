public class Solution {
    public string solution(string s) {
        string answer = "";
        if(s.Length%2 == 0)
            answer = s.Substring((s.Length-1)/2, 2);
        else
            answer = s.Substring((s.Length-1)/2, 1);
        return answer;
    }
}