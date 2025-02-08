using System;
using System.Linq;

public class Solution {
    public string solution(string polynomial) {
        int sumX = 0;
        int sumN = 0;
        string[] splited = polynomial.Split(' ').Where(str => str != "+").ToArray();
        
        for (int index = 0; index < splited.Length; index++)
        {
            var currentString = splited[index];
            if (char.IsNumber(currentString[currentString.Length - 1]))
                sumN += Convert.ToInt32(currentString);
            else if (int.TryParse(currentString.Substring(0, currentString.Length - 1), out int parsedNum))
                sumX += parsedNum;
            else
                sumX++;
        }
        
        var sumXResult = sumX > 1 ? $"{sumX}" : "";
        
        if (sumX != 0 && sumN != 0)
            return $"{sumXResult}x + {sumN}";
        else if (sumX == 0)
            return $"{sumN}";
        else if (sumN == 0)
            return $"{sumXResult}x";
        else
            return "0";
    }
}