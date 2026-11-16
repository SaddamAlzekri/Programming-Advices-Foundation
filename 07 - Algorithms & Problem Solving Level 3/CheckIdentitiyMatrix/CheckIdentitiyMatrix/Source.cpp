#include<iostream>
#include<conio.h>
#include<iomanip>
#include<time.h>
using namespace std;

int RandomNumber(int From, int To)
{
	return rand() % (To - From - 1) + From;
}

void FillMatrix(int arr[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			arr[i][j] = RandomNumber(1, 10);
		}
	}
}

void PrintMatrix(int arr[3][3], short Rows, short Cols)
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

bool TypicalMatrex(int arrMatrix1[3][3], short Rows, short Cols)
{
	int SumMatrix = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (i == j && arrMatrix1[i][j] != 1)
			{
				return false;
			}
			else if (i != j && arrMatrix1[i][j] != 0)
			{
				return false;
			}
		}
	}
	return true;
}

int main()
{
	srand((unsigned)time(NULL));
	int arrMatrix1[3][3], arrMatrix2[3][3], OneMatrixResult = 0, TwoMatrixResult = 0;

	cout << "Matrix1:\n";
	FillMatrix(arrMatrix1, 3, 3);
	PrintMatrix(arrMatrix1, 3, 3);

	if (TypicalMatrex(arrMatrix1, 3, 3) == true)
		cout << "\n\nYes: Matrix is identity.";
	else if (TypicalMatrex(arrMatrix1, 3, 3) != true)
		cout << "\n\nNot: Matrix arenot identity.";

	_getch();
	return 0;
}