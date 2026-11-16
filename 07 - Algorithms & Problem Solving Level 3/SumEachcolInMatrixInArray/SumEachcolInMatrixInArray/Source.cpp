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
			cout <<arr[i][j] << setw(5);
		}
		cout << "\n";
	}
}

int SumCol(int arr[3][3], int NumberCols, int Cols)
{
	int Sum = 0;
	for (int i = 0; i < Cols; i++)
		Sum += arr[i][NumberCols];

	return Sum;
}

void SumEachColToArray(int arr[3][3], int arr2[3], int Cols)
{
	for (int i = 0; i < Cols; i++)
		arr2[i] = SumCol(arr, i, Cols);
}

void PrintColsSumFromArray(int arr2[3], int Cols)
{
	for (int i = 0; i < Cols; i++)
		cout << "Col " << i + 1 << " Sum = " << arr2[i] << endl;
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3], arr2[3];

	FillMatrixWithRandomNumbers(arr, 3, 3);
	cout << "The following is a 3x3 random matrix:\n";
	Print2DaimentionMatrix(arr, 3, 3);
	SumEachColToArray(arr, arr2, 3);
	cout << "\nThe following are the sumof each row in the matrix:\n";
	PrintColsSumFromArray(arr2, 3);

	_getch();
	return 0;
}