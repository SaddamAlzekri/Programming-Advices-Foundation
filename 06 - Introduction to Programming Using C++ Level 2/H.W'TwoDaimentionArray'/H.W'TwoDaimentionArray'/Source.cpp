#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int arr[10][10];

	for (int i = 1; i <= 10; i++)
	{
		for (int k = 1; k <= 10; k++)
		{
			arr[i][k] = i * k;
			printf("%0*d\t", 2, arr[i][k]);
		}
		cout << endl;
	}
	_getch();
	return 0;
}