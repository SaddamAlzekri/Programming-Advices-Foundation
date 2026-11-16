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

bool AreTypicalMatrex(int arrMatrix1[3][3], int arrMatrix2[3][3], short Rows, short Cols)
{
	int SumMatrix = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (arrMatrix1[i][j] != arrMatrix2[i][j])
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

	cout << "\nMatrix2:\n";
	FillMatrix(arrMatrix2, 3, 3);
	PrintMatrix(arrMatrix2, 3, 3);

	if (AreTypicalMatrex(arrMatrix1, arrMatrix2, 3, 3))
		cout << "\n\nYes: Matrix are typicaly.";
	else
		cout << "\n\nNot: Matrix arenot typicaly.";

	_getch();
	return 0;
}