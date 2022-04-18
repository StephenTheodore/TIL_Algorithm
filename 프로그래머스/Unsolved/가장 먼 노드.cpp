#include <iostream>
#include <vector>
#include <deque>
#include <map>

using namespace std;

int solution(int n, vector<vector<int>> edges)
{
    int max = 0;
    int answer = 0;
    map<int, int> nodeMap;
    deque<int> curNode, nextNode;
    
    curNode.push_back(1);
    nodeMap.emplace(1, 0);
    for (int i = 0; !edges.empty(); i++)
    {
        for (const int &node : curNode)
        {
            if (nodeMap.find(node) != nodeMap.end())
                continue;
            for (vector<vector<int>>::iterator edge = edges.begin(); edge != edges.end();)
            {
                int start = edge->front();
                int dest = edge->back();
                if (start == node)
                {
                    if (nodeMap.find(dest) == nodeMap.end())
                    {
                        nextNode.push_back(dest);
                        nodeMap.emplace(dest, i + 1);
                    }
                    edge = edges.erase(edge);
                }
                else if (dest == node)
                {
                    nextNode.push_back(start);
                    edge++;
                }
                else
                    edge++;
            }
        }
        curNode = nextNode;
        nextNode.clear();
    }
    for (map<int,int>::iterator dist = nodeMap.begin(); dist != nodeMap.end();)
    {
        if (max < dist->second)
        {
            max = dist->second;
            answer = 0;
        }
        answer++;
        dist++;
    }
    return answer;
}
int main()
{
    cout << solution(6, { {3,6},{4,3},{3,2},{1,3},{1,2},{2,4},{5,2} }) << endl;
}
