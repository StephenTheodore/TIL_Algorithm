#include <stdio.h>
#include <queue>

using namespace std;

int main()
{
	int N, value;
	queue<int> Q;
	scanf("%d", &N);

	for (int i = 1; i <= N; i++)
		Q.push(i);
	if (N == 1)
	{
		printf("1\n");
		return 0;
	}
	while (true)
	{
		Q.pop();
		value = Q.front();
		Q.pop();
		if (Q.size())
			Q.push(value);
		else
		{
			printf("%d\n", value);
			return 0;
		}
	}
}