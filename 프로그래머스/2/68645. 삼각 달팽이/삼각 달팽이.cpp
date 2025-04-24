#include <string>
#include <vector>

using namespace std;

vector<int> solution(int n) {
    vector<int> answer;
    vector<vector<int>> snail(n);
    int totalCount = 0;
    
    for (int index = 0; index < n; index++)
    {
        int colCount = index + 1;
        snail[index] = vector<int>(colCount);
        totalCount += colCount;
    }
    
    vector<char> directions = vector<char> { 'D', 'R', 'U' };
    vector<char>::iterator direction = directions.begin();
    
    int number = 0;
    int row = 0, col = 0;
    while (number++ < totalCount)
    {
        snail[row][col] = number;
        
        switch (*direction)
        {
            case 'D':
                if (snail.size() > row + 1 && snail[row + 1][col] == 0)
                    row++;
                else
                {
                    direction++;
                    col++;
                }
                break;
            case 'R':
                if (snail[row].size() > col + 1 && snail[row][col + 1] == 0)
                    col++;
                else
                {
                    direction++;
                    row--;
                    col--;
                }
                break;
            case 'U':
                if (0 <= row - 1 && snail[row - 1][col - 1] == 0)
                {
                    row--;
                    col--;
                }
                else
                {
                    direction++;
                    row++;
                }
                break;
        }
        
        if (direction == directions.end())
            direction = directions.begin();
    }
    
    for (const auto& row : snail)
        answer.insert(answer.end(), row.begin(), row.end());
    
    return answer;
}