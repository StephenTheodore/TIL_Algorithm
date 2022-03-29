public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        char[] temp = new char[phone_number.Length];
        
        temp = phone_number.ToCharArray();
        for(int i=0; i<phone_number.Length-4; i++)
        {
            temp[i] = '*';
        }
        
        answer = string.Concat(temp);
        
        return answer;
    }
}