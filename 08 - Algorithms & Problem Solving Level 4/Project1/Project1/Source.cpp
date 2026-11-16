#include<iostream>
#include<conio.h>
using namespace std;

int main()
{
	int x[5] = { 1, 2, 3, 4, 5 };

	int C1 = x[0];
	for (int i = 1; i < 5; i++)
	{
		if (C1 >= x[i])
		{
			C1 = C1;
		}
		else
		{
			C1 = x[i];
		}
	}
	cout << C1;
	_getch();
	return 0;
}