#include <bits/stdc++.h>

using namespace std;

long long Calcualte(string opPriority, deque<long long> numbers, deque<char> operators)
{
    for (const char& oper : opPriority)
    {
        auto opIter = find(operators.begin(), operators.end(), oper);
        while (opIter != operators.end())
        {
            int index = distance(operators.begin(), opIter);
            
            if (*opIter == '+')
                numbers[index] = numbers[index] + numbers[index + 1];
            else if (*opIter == '-')
                numbers[index] = numbers[index] - numbers[index + 1];
            else
                numbers[index] = numbers[index] * numbers[index + 1];
            
            numbers.erase(numbers.begin() + index + 1);
            operators.erase(operators.begin() + index);
            opIter = find(operators.begin(), operators.end(), oper);
        }
    }
    
    return abs(numbers.front());
}

long long solution(string expression) {
    priority_queue<long long> answer;
    vector<string> opPriorities =
    {
        "*+-", "*-+",
        "-*+", "-+*",
        "+-*", "+*-",
    };

    deque<long long> numbers;
    deque<char> operators;

    string numString = "";
    for (const char& ch : expression)
    {
        if (isdigit(ch))
            numString += ch;
        else
        {
            if (numString.size())
            {
                numbers.push_back(stoll(numString));
                numString = "";
            }
            operators.push_back(ch);
        }
    }
    if (numString.size())
        numbers.push_back(stoll(numString));
    
    for (string opPriority : opPriorities)
    {
        long long calcResult = Calcualte(opPriority, numbers, operators);
        cout << "Result\t" << calcResult << endl;
        answer.push(calcResult);
    }
        
    return answer.top();
}