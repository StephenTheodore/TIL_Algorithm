#include <stdio.h>
#include <set>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	int N;
	char s[51];
	set<string> input;
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%s", &s);
		input.insert(s);
	}

	vector<string> arr(input.begin(), input.end());
	arr.erase(unique(arr.begin(), arr.end()), arr.end());
	sort(arr.begin(), arr.end(), [](string a, string b)-> bool
		{
			if (a.size() != b.size())
				return a.size() < b.size();
			else
			{
				for (size_t i = 0; i < a.size(); i++)
				{
					if (a[i] > b[i])
						return false;
					else if (a[i] < b[i])
						return true;
				}
			}
		});
	for (string s : arr)
		printf("%s\n", s.c_str());
}
