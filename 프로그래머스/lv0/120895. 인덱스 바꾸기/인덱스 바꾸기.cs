using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) 
    {
        StringBuilder sb = new StringBuilder();
        char c1 = my_string[num2], c2 = my_string[num1];
        
        for(int index = 0; index < my_string.Length; index++)
        {
            if(index == num1)
                sb.Append(c1);
            else if (index == num2)
                sb.Append(c2);
            else
                sb.Append(my_string[index]);
        }
        
        return sb.ToString();
    }
}