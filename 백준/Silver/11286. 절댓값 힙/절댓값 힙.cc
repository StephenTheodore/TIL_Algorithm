#include <cstdio>
#include <cmath>
#include <queue>

using namespace std;

struct Absolute
{
	bool operator()(int& a, int& b)
	{
		if (abs(a) == abs(b))
			return a > b;
		return abs(a) > abs(b);
	}
};
int main()
{
	int N;
	priority_queue<int, vector<int>, Absolute> Heap;

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