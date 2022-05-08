#include <cstdio>

using namespace std;

int main()
{
	char input[102];
	while (fgets(input, sizeof(input), stdin))
		printf("%s", input);
}