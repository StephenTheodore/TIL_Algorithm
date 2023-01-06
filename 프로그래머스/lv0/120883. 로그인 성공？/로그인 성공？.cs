using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public string solution(string[] id_pw, string[,] db)
    {
            Dictionary<string, string> infos = new Dictionary<string, string>();
            for (int index = 0; index < db.GetLength(0); index++)
                infos.Add(db[index, 0], db[index, 1]);
            if (infos.ContainsKey(id_pw[0]))
            {
                if (infos[id_pw[0]] == id_pw[1])
                    return "login";
                else
                    return "wrong pw";
            }
            else
                return "fail";
    }
}