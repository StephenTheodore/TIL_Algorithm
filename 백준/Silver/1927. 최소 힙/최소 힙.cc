#include <cstdio>
#include <queue>

using namespace std;

int main()
{
	int N;
	priority_queue<int, vector<int>, greater<int>> Heap;

	scanf("%d", &N);
	for (int i = 0, x; i < N; i++)
	{
		scanf("%d", &x);
		if (x == 0)
		{
			if (Heap.empty())
				printf("0\n");
			else
			{
				printf("%d\n", Heap.top());
				Heap.pop();
			}
		}
		else
			Heap.push(x);
	}
}