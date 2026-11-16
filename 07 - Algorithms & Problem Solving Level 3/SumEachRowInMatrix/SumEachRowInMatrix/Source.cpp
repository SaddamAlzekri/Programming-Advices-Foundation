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

void PrintMatrix(int arr[3][3], short Rows, short Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			cout << setw(5) << arr[i][j] ;
		}
		cout << "\n";
	}
}

int RowSum(int arr[3][3], short RowNumber, short Cols)
{
	int Sum = 0;
	for (int i = 0; i < Cols; i++)
	{
		Sum += arr[RowNumber][i];
	}
	return Sum;
}

void PrintEachRowsum(int arr[3][3], short Rows, short Cols)
{
	int Sum = 0;
	for (int i = 0; i < Cols; i++)
		cout << "Row " << i + 1 << " Sum = " << RowSum(arr, i, Cols) << endl;
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3];

	FillMatrixWithRandomNumbers(arr, 3, 3);
	cout << "The following is a 3x3 random matrix:\n";
	PrintMatrix(arr, 3, 3);
	cout << "\nThe following are the sumof each row in the matrix:\n";
	PrintEachRowsum(arr, 3, 3);
	_getch();
	return 0;
}