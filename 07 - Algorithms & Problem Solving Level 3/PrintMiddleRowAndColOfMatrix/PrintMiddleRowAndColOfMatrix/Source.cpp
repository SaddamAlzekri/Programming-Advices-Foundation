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

void PrintOrderNumberArray(int arr[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			printf(" %0*d  ", 2, arr[i][j]);
		}
		cout << "\n";
	}
}

void MiddleRowOfMatrix(int arr[3][3], short Rows, short Cols)
{
	short MiddleRow = Rows / 2;
	for (short i = 0; i < Cols; i++)
	{
		printf(" %0*d  ", 2, arr[MiddleRow][i]);
	}
	cout << "\n";
}

void MiddleColOfMatrix(int arr[3][3], short Rows, short Cols)
{
	short MiddleCol = Cols / 2;
	for (short i = 0; i < Rows; i++)
	{
		printf(" %0*d  ", 2, arr[i][MiddleCol]);
	}
	cout << "\n";
}
int main()

{
	srand((unsigned)time(NULL));

	int arr[3][3], arr2[3][3], MiddleRow[3], MiddleCol[3];
	FillOrderNumberToArray(arr, 3, 3);
	cout << "Matrix 1:\n";
	PrintOrderNumberArray(arr, 3, 3);
	cout << "\nMiddle Row of Matrix is:\n";
	MiddleRowOfMatrix(arr, 3, 3);

	cout << "\n\nMiddle Col of Matrix is:\n";
	MiddleColOfMatrix(arr, 3, 3);

	_getch();
	return 0;
}