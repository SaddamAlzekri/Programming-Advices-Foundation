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

void FillOrderNumberToArray(int arr[3][3], int Rows, int Cols)
{
	int Counter = 0;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			arr[i][j] = RandomNumber(1, 10);
		}
	}
}

void PrintOrderNumberArray(int arr[3][3], int Rows, int Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			printf(" %0*d  ", 2, arr[i][j]);
		}
		cout << "\n";
	}
}

int SumOfMatrix(int arr[3][3], int Rows, int Cols)
{
	int SumOfMatrix = 0;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			SumOfMatrix += arr[i][j];
		}
	}
	return SumOfMatrix;
}

int main()
{
	srand((unsigned)time(NULL));

	int arr[3][3], arr2[3][3], MiddleRow[3], MiddleCol[3], vSumOfMatrix;
	FillOrderNumberToArray(arr, 3, 3);
	cout << "Matrix 1:\n";
	PrintOrderNumberArray(arr, 3, 3);
	cout<<"\nSum of Matrix is: "<<SumOfMatrix(arr, 3, 3);
	_getch();
	return 0;
}