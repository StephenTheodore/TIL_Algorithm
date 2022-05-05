#include <stdio.h>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int N;
	int age;
	char name[101];
	vector<pair<int, pair<int, string>>> users;
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%d %s", &age, &name);
		users.push_back(make_pair(i, make_pair(age, name)));
	}
	sort(users.begin(), users.end(),
		[](pair<int, pair<int, string>> a, pair < int, pair<int, string>> b) -> bool
		{
			if (a.second.first != b.second.first)
				return a.second.first < b.second.first;
			else
				return a.first < b.first;
		});

	for (pair<int, pair<int, string>> user : users)
		printf("%d %s\n", user.second.first, user.second.second.c_str());
}