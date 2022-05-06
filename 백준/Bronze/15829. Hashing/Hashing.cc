#include <stdio.h>
#include <string>

using namespace std;

int main()
{
	int L;
	const int r = 31, M = 1234567891;
	char input[52];

	scanf("%d", &L);
	scanf("%s", &input);

	string str = input;
	long long sum = 0;
	long long R;
	for (int i = 0; i < L; i++)
	{
		R = 1;
		for (int j = 1; j <= i; j++)
			R = (R * r) % M;
		sum += (str[i] - 'a' + 1) * R;
	}
	printf("%lld", sum % M);
}