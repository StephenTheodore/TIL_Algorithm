#include <stdio.h>
#include <deque>
#include <string>

using namespace std;

int main()
{
	int N, value;
	deque<int> dq;
	string cmd;
	char input[20];
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%s", &input);
		cmd = input;

		if (cmd == "push_front")
		{
			scanf("%d", &value);
			dq.push_front(value);
		}
		else if (cmd == "push_back")
		{
			scanf("%d", &value);
			dq.push_back(value);
		}
		else if (cmd == "pop_front")
		{
			if (dq.size())
			{
				value = dq.front();
				dq.pop_front();
				printf("%d\n", value);
			}
			else
				printf("-1\n");
		}
		else if (cmd == "pop_back")
		{
			if (dq.size())
			{
				value = dq.back();
				dq.pop_back();
				printf("%d\n", value);
			}
			else
				printf("-1\n");
		}
		else if (cmd == "front")
		{
			printf("%d\n", dq.size() ? dq.front() : -1);
		}
		else if (cmd == "back")
			printf("%d\n", dq.size() ? dq.back() : -1);
		else if (cmd == "empty")
			printf("%d\n", dq.empty());
		else if (cmd == "size")
			printf("%d\n", dq.size());
	}
}