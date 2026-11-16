#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

void PrintNToM(int N, int M)
{
	if (M >= N)
	{
		cout << M << endl;
		PrintNToM(N, M - 1);
	}
}
int main()
{
	PrintNToM(1, 10);
	_getch();
	return 0;
}