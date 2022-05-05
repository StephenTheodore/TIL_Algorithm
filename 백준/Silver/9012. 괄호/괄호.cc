#include <stdio.h>
#include <string>
#include <stack>

using namespace std;

bool isVPS(string str)
{
	stack<char> st;
	for (int i = 0; i < str.size(); i++)
	{
		if (st.size())
		{
			if (st.top() == str[i])
				st.push(str[i]);
			else
				st.pop();
		}
		else if (str[i] == ')')
			return false;
		else
			st.push(str[i]);
	}
	return st.size() ? false : true;
}
int main()
{
	int T;
	char input[51];
	scanf("%d", &T);

	while (T--)
	{
		scanf("%s", &input);
		printf("%s\n", isVPS(input) ? "YES" : "NO");
	}
}