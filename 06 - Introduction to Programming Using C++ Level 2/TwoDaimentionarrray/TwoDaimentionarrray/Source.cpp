#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int arr[3][4] = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 4; j++)
			(arr[i][j] > 9) ? printf("%d\t", arr[i][j]) : printf("%0*d\t", 2, arr[i][j]);

		cout << endl;
	}
	_getch();
	return 0;
}