using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) => todo_list
        .Zip(finished, (todo, done) => new { todo, done } )
        .Where(pair => pair.done == false)
        .Select(pair => pair.todo)
        .ToArray();
}