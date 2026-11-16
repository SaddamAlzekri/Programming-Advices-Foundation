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
			arr[i][j] = Counter + 1;
			Counter++;
		}
	}
}

void TrasposeMatrix(int arr[3][3],int arr2[3][3], int Rows, int Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			arr2[i][j] = arr[j][i];
		}
	}
}

void PrintOrderNumberArray(int arr[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			cout << " " << arr[i][j] << setw(5);
		}
		cout << "\n";
	}
}

int main()
{
	int arr[3][3], arr2[3][3];
	FillOrderNumberToArray(arr, 3, 3);

	cout << "The following is a 3x3 ordered matrix:\n";
	PrintOrderNumberArray(arr, 3, 3);

	TrasposeMatrix(arr,arr2, 3, 3);
	
	cout << "\nThe following is the transpose matrix:\n";
	PrintOrderNumberArray(arr2, 3, 3);
	_getch();
	return 0;
}