#include <iostream>
#include <vector>
#include <queue>
#include <string>
#include <map>

using namespace std;

int solution(int n, vector<vector<int>> edges) {
    int answer = 0;
    map<int, int> nodeMap;
    queue<int> curNode;

    curNode.push(1);
    nodeMap.insert(1, 0);
    while (!edges.empty())
    {
        queue<int> nextNode;
        for (int i = 0; i < curNode.size(); i++)
        {
            int node = curNode.front();
            curNode.pop();
            for (vector<vector<int>>::iterator iter = edges.begin(); iter != edges.end();)
            {
                vector<int> edge = *iter;
                //새 노드가 발견되면 edges로부터 순차적으로 지우지 말고 한번에 지우기
                if (edge[0] == node)
                {
                    nodeMap.insert(edge[0], i + 1);
                    iter = edges.erase(iter);
                }
                else if (edge[1] == node)
                {
                    nodeMap.insert(edge[1], i + 1);
                    iter = edges.erase(iter);
                }
                else
                    iter++;
            }
        }
        curNode = nextNode;
    }
    //아직 방문하지 않은 노드는 Map에 없다.
    //지워진 값들은 현재 Map의 지나온 간선개수 +1을 하여 저장한다. 이때 기존값이 있으면 패스

    return answer;
}
int main()
{

}
