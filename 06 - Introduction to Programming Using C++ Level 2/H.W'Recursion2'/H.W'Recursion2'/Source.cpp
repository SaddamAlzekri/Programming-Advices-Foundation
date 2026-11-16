#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int PrintNToM(int N, int M)
{
	if (M == 0)
		return 1;
	else
		return (N * PrintNToM(N, M - 1));
}
int main()
{
	cout << PrintNToM(4, 4);
	_getch();
	return 0;
}