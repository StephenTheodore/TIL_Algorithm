#include <math.h>
#include <vector>
#include <queue>

using namespace std;

long long solution(int n, vector<int> works)
{
    long long answer = 0;
    priority_queue<int, vector<int>> heap;
    for (int var : works)
        heap.push(var);
    while (n != 0 && heap.size() != 0)
    {
        int d = heap.top() - 1;
        if (d != 0)
            heap.push(d);
        heap.pop();
        n--;
    }
    while (heap.size() != 0)
    {
        int d = heap.top();
        heap.pop();
        answer += d * d;
    }

    return answer;
}