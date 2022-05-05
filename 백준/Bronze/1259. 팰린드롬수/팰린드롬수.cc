#include <stdio.h>
#include <string>

using namespace std;

bool isPalindrome(string S)
{
	string C = "";
	for (int i = S.size() - 1; i >= 0; i--)
	{
		C += S[i];
	}
	for (int i = 0; i < S.size(); i++)
	{
		if (C[i] != S[i])
			return false;
	}
	return true;
}
int main()
{
	char N[6];
	string S;
	while (true)
	{
		scanf("%s", &N);
		S = N;
		if (S == "0")
			break;
		printf("%s\n", isPalindrome(S) ? "yes" : "no");
	}
}
