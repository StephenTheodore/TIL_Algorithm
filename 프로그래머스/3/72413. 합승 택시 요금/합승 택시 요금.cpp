#include <bits/stdc++.h>

using namespace std;

int solution(int n, int s, int a, int b, vector<vector<int>> fares)
{
    int answer = INT_MAX;
    
    vector<vector<int>> costs(n, vector<int>(n, INT_MAX));
    
    for (int index = 0; index < costs.size(); index++)
        costs[index][index] = 0;
    
    for (const auto& fare : fares)
    {
        int node1Id = fare[0] - 1, node2Id = fare[1] - 1;   // zero-based
        int cost = fare[2];
        
        costs[node1Id][node2Id] = cost;
        costs[node2Id][node1Id] = cost;
    }
    
    for (int wayPoint = 0; wayPoint < n; wayPoint++)
    {
        for (int start = 0; start < n; start++)
        {
            for (int dest = 0; dest < n; dest++)
            {
                if (costs[start][wayPoint] != INT_MAX && costs[wayPoint][dest] != INT_MAX)
                    costs[start][dest] = min(costs[start][dest], costs[start][wayPoint] + costs[wayPoint][dest]);   
            }
        }
    }
    
    s--; a--; b--; //zero-based
    for (int index = 0; index < costs.size(); index++)
    {
        if (costs[s][index] != INT_MAX && costs[index][a] != INT_MAX && costs[index][b] != INT_MAX)
        {
            int wayPointCost = costs[s][index] + costs[index][a] + costs[index][b];
            answer = min(answer, wayPointCost);
        }
    }
    
    return answer;
}