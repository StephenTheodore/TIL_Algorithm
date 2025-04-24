#include <bits/stdc++.h>

using namespace std;

vector<int> solution(vector<string> keymap, vector<string> targets) {
    vector<int> answer;
    map<char, int> minClickCounts;
    map<char, int>::iterator iterPointer;
    
    for (char ch = 'A'; ch <= 'Z'; ch++)
        minClickCounts[ch] = 0;
    
    for (auto keys : keymap)
    {
        for (int keyIndex = 0; keyIndex < keys.size(); keyIndex++)
        {
            auto currentClickCount = &minClickCounts[keys[keyIndex]];
            if (*currentClickCount == 0 || *currentClickCount > keyIndex + 1)
                *currentClickCount = keyIndex + 1;
        }
    }
    
    for (int targetIndex = 0; targetIndex < targets.size(); targetIndex++)
    {
        string targetString = targets[targetIndex];
        answer.push_back(0);
        
        for (auto targetChar : targetString)
        {
            int clickCount = minClickCounts[targetChar];
            if (clickCount != 0)
                answer[targetIndex] += clickCount;
            else
            {
                answer[targetIndex] = -1;
                break;
            }
        }
    }
    
    return answer;
}