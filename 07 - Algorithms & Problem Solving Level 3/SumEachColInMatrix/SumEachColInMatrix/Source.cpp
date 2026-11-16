#include<iostream>
#include<conio.h>
#include<iomanip>
#include<stdlib.h>
#include<time.h>

using namespace std;

int RandomNumber(int From, int To)
{
	return rand() % (To - From + 1) + From;
}

void FillMatrixWithRandomNumbers(int arr[3][3], short Rows, short Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			arr[i][j] = RandomNumber(1, 100);
		}
	}
}

void Print2DaimentionMatrix(int arr[3][3], short Rows, short Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			cout << arr[i][j] << setw(7);
		}
		cout << "\n";
	}
}

int RowCols(int arr[3][3], int NumberCol, int Cols)
{
	int Sum = 0;
	for (int i = 0; i < Cols; i++)
	{
		Sum += arr[i][NumberCol];
	}
	return Sum;
}

void PrintEachColsSum(int arr[3][3], int Cols)
{
	for (int i = 0; i < Cols; i++)
		cout << "Col " << i + 1 << " Sum = " << RowCols(arr, i, Cols) << endl;
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3], sumArray[3];

	FillMatrixWithRandomNumbers(arr, 3, 3);
	cout << "The following is a 3x3 random matrix:\n";
	Print2DaimentionMatrix(arr, 3, 3);

	cout << "\nThe following are the sumof each row in the matrix:\n";
	PrintEachColsSum(arr, 3);

	_getch();
	return 0;
}


