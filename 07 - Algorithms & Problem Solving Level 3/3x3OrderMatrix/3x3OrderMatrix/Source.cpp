#include<iostream>
#include<conio.h>
#include<iomanip>
using namespace std;

void FillOrderNumberToArray(int arr[3][3], short Rows, short Cols)
{
	short Counter = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			Counter++;
			arr[i][j] = Counter;
			
		}
	}
}

void PrintOrderNumberArray(int arr[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			cout <<" "<<arr[i][j] << setw(5);
		}
		cout << "\n";
	}
}

int main()
{
	int arr[3][3];
	FillOrderNumberToArray(arr, 3, 3);
	cout << "The following is a 3x3 ordered matrix:\n";
	PrintOrderNumberArray(arr, 3, 3);
	_getch();
	return 0;
}