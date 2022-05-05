#include <stdio.h>
#include <queue>
#include <algorithm>

using namespace std;

queue<int> circle;
void Josephus(int K)
{
	int count = 0;
	int person;
	printf("<");
	while (circle.size() > 1)
	{
		count++;
		if (count == K)
		{
			count = 0;
			printf("%d, ", circle.front());
			circle.pop();
		}
		else
		{
			person = circle.front();
			circle.pop();
			circle.push(person);
		}
	}
	printf("%d>\n", circle.front());
}
int main()
{
	int N, K;

	scanf("%d %d", &N, &K);
	for (int i = 1; i <= N; i++)
		circle.push(i);

	Josephus(K);
}