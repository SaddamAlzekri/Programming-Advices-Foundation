#include<iostream>
#include<conio.h>
#include<iomanip>
#include<time.h>
#include<stdlib.h>
using namespace std;
int RandomNumber(int From, int To)
{
	return rand() % (To - From - 1) + From;
}

void FillOrderNumberToArray(int arr[3][3], short Rows, short Cols)
{
	short Counter = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			arr[i][j] = RandomNumber(1, 10);
		}
	}
}

void PrintOrderNumberArray(int arr[3][3], int Rows, int Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			printf(" %0*d", 2, arr[i][j]);
		}
		cout << "\n";
	}
}

void Multiply2Matrix(int arr[3][3], int arr2[3][3], int arrResult[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			arrResult[i][j] = arr[i][j] * arr2[i][j];
		}
	}
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3], arr2[3][3], arrResult[3][3];

	FillOrderNumberToArray(arr, 3, 3);
	
	cout << "Matrix 1:\n";
	PrintOrderNumberArray(arr, 3, 3);
	
	FillOrderNumberToArray(arr2, 3, 3);
	
	cout << "\nMatrix 2:\n";
	PrintOrderNumberArray(arr2, 3, 3);
	
	Multiply2Matrix(arr, arr2, arrResult, 3, 3);
	
	cout << "\nResult:\n";
	PrintOrderNumberArray(arrResult, 3, 3);
	_getch();
	return 0;
}