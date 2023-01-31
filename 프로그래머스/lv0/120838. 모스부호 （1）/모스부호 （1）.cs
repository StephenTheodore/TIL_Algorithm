using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string letter)
    {
        StringBuilder sb = new StringBuilder();
        var morse = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        var dictConvert = new Dictionary<string,char>();
        
        for(int index = 0; index < morse.Length; index++)
            dictConvert.Add(morse[index], (char)('a'+index));
        foreach(var str in letter.Split(' '))
            sb.Append(dictConvert[str]);
        
        return sb.ToString();
    }
}