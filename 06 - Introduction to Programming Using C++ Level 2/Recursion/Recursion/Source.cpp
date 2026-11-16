#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

void PrintNToM(int N, int M)
{
	if (N <= M)
	{
		cout << N << endl;
		PrintNToM(N + 1, M);
	}
}
int main()
{
	PrintNToM(1, 10);
	_getch();
	return 0;
}