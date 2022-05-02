#include <stdio.h>
#include <queue>

using namespace std;

int main()
{
	int N, M;
	scanf("%d", &N);
	priority_queue<int, vector<int>, greater<int>> pq;

	for (int i = 0; i < N; i++)
	{
		scanf("%d", &M);
		pq.push(M);
	}
	for (int i = 0; i < N; i++)
	{
		printf("%d\n", pq.top());
		pq.pop();
	}
}