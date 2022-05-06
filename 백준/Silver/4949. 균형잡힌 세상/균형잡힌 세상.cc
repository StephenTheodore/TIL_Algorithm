#include <cstdio>
#include <string>
#include <stack>

using namespace std;

bool isBalanced(string str)
{
	stack<char> st;
	for (char c : str)
	{
		if (c == '(' || c == '[')
			st.push(c);
		else if (c == ')' || c == ']')
		{
			if (st.empty())
				return false;
			if ((st.top() != '(' && c == ')') || st.top() != '[' && c == ']')
				return false;
			else
				st.pop();
		}
	}
	if (st.empty())
		return true;
	else
		return false;
}
int main()
{
	char input[102];

	while (true)
	{
		fgets(input, 102, stdin);
		if (input[0] == '.')
			break;
		printf("%s\n", isBalanced(input) ? "yes" : "no");
	}
}