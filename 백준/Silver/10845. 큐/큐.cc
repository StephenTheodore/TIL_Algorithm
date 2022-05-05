#include <stdio.h>
#include <queue>
#include <string>

using namespace std;

int main()
{
	int N, value;
	queue<int> q;
	string cmd;
	char input[20];
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%s", &input);
		cmd = input;

		if (cmd == "push")
		{
			scanf("%d", &value);
			q.push(value);
		}
		else if (cmd == "pop")
		{
			if (q.size())
			{
				value = q.front();
				q.pop();
				printf("%d\n", value);
			}
			else
				printf("-1\n", value);
		}
		else if (cmd == "size")
			printf("%d\n", q.size());
		else if (cmd == "empty")
			printf("%d\n", q.empty());
		else if (cmd == "front")
			printf("%d\n", q.size() ? q.front() : -1);
		else if (cmd == "back")
			printf("%d\n", q.size() ? q.back() : -1);
	}
}