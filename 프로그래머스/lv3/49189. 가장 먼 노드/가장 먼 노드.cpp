#include <vector>
#include <set>
#include <map>
#include <algorithm>

using namespace std;

int solution(int n, vector<vector<int>> edges)
{
    int max = 0;
    int answer = 0;
    map<int, int> nodeMap;
    set<int> current, next;

    sort(edges.begin(), edges.end());
    current.insert(1);

    for (int i = 0; nodeMap.size() != n; i++)
    {
        for (const int& node : current)
        {
            nodeMap.emplace(node, i);
            for (vector<vector<int>>::iterator edge = edges.begin(); edge != edges.end();)
            {
                int start = edge->front();
                int dest = edge->back();

                if (start == node)
                {
                    next.insert(dest);
                    edge = edges.erase(edge);
                }
                else
                {
                    if (dest == node)
                        next.insert(start);
                    edge++;
                }
            }
        }
        current = next;
        next.clear();
    }
    for (map<int, int>::iterator dist = nodeMap.begin(); dist != nodeMap.end();)
    {
        if (max < dist->second)
        {
            max = dist->second;
            answer = 0;
        }
        if (max == dist->second)
            answer++;
        dist++;
    }
    return answer;
}