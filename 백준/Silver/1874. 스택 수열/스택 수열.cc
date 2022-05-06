#include <stdio.h>
#include <string>
#include <stack>
#include <queue>

using namespace std;

int main()
{
	int N, value;
	int num = 1;
	string result = "";
	queue<int> q;
	stack<int> st;

	scanf("%d", &N);
	for (int i = 1; i <= N; i++)
	{
		scanf("%d", &value);
		q.push(value);
	}
	while (num<=N)
	{
		if (st.empty())
		{
			st.push(num++);
			result += "+\n";
		}
		else if (st.top() == q.front())
		{
			q.pop();
			st.pop();
			result += "-\n";
		}
		else
		{
			st.push(num++);
			result += "+\n";
		}
	}
	while (q.size())
	{
		if (q.front() != st.top())
			break;
		q.pop();
		st.pop();
		result += "-\n";
	}
	if (q.size())
		printf("NO\n");
	else
		printf("%s\n", result.c_str());
}