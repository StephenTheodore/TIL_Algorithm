#include <bits/stdc++.h>
using namespace std;

bool solution(string s)
{
    int answer = 0;

    for (int index = 0; index < s.size(); index++)
    {
        char ch = tolower(s[index]);
        if (ch == 'p')
            answer--;
        if (ch == 'y')
            answer++;
    }
    
    return answer == 0;
}