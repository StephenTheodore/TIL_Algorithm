#include <stdio.h>

using namespace std;

bool isRightTriangle(int a, int b, int c)
{
	if (a + b == c || b + c == a || c + a == b)
		return true;
	return false;
}
int main()
{
	int N[3];

	while (true)
	{
		for (int i = 0; i < 3; i++)
		{
			scanf("%d", &N[i]);
			N[i] *= N[i];
		}
		if (N[0] && N[1] && N[2])
			printf("%s\n", isRightTriangle(N[0], N[1], N[2]) ? "right" : "wrong");
		else
			break;
	}
}