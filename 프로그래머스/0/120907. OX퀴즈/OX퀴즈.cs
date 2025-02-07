using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] quiz) => quiz.Select(q => CheckQuiz(q)).ToArray();
    
    private string CheckQuiz(string quiz)
    {
        var sp = quiz.Split(' ');
        var num1 = Convert.ToInt32(sp[0]);
        var num2 = Convert.ToInt32(sp[2]);
        var answer = Convert.ToInt32(sp[4]);
        
        bool isCorrect;
        if (sp[1] == "+")
            isCorrect = num1 + num2 == answer;
        else
            isCorrect = num1 - num2 == answer;
        
        return isCorrect ? "O" : "X";
    }
}