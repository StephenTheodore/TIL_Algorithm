#include <string>
#include <vector>
#include <queue>
#include <stack>

using namespace std;

int solution(vector<vector<int>> board, vector<int> moves) {
    int answer = 0;
    vector<queue<int>> buckets(board.size());
    stack<int> pickedDolls;
    
    for (const auto& row : board)
    {
        for (int col = 0; col < row.size(); col++)
        {
            int dollNumber = row[col];
            if(dollNumber != 0)
                buckets[col].push(dollNumber);
        }
    }
    
    for (const int& moveIndex : moves)
    {
        queue<int>* bucket = &buckets[moveIndex - 1];
        if ((*bucket).size())
        {
            int dollNumber = (*bucket).front();
            (*bucket).pop();
            
            if (pickedDolls.size() && pickedDolls.top() == dollNumber)
            {
                pickedDolls.pop();
                answer += 2;
            }
            else
                pickedDolls.push(dollNumber);
        }
    }
    
    return answer;
}