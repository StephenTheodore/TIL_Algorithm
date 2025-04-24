#include <string>
#include <vector>

using namespace std;

string solution(vector<string> cards1, vector<string> cards2, vector<string> goal) {
    string answer = "Yes";
    int cards1Index = 0;
    int cards2Index = 0;
    
    for (const string& sentence : goal)
    {
        if (sentence == cards1[cards1Index])
            cards1Index++;
        else if (sentence == cards2[cards2Index])
            cards2Index++;
        else
        {
            answer = "No";
            break;
        }
    }
    
    return answer;
}