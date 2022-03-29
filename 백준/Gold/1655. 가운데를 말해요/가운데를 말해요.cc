#include <stdio.h>
#include <vector>
#include <queue>
#include <string>

using namespace std;

int main()
{
	priority_queue<int, vector<int>, less<int>> left;
	priority_queue<int, vector<int>, greater<int>> right;
	string result = "";
	int N, numInput;
	int tmp[2];

	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%d", &numInput);

		if (right.size() >= left.size())
			left.push(numInput);
		else
			right.push(numInput);
		if (right.size()!=0 && left.top() > right.top())
		{
			tmp[0] = left.top();
			tmp[1] = right.top();
			left.pop();
			right.pop();
			left.push(tmp[1]);
			right.push(tmp[0]);
		}
		result.append(to_string(left.top()) + "\n");
	}
	printf("%s", result.c_str());
	return 0;
}