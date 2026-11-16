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

bool ScolarMatrex(int arrMatrix1[3][3], short Rows, short Cols)
{
	int FirstDiagElement = arrMatrix1[0][0];
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (i == j && arrMatrix1[i][j] != FirstDiagElement)
			{
				return false;
			}
			else if (i != j && arrMatrix1[i][j] != 0)
			{
				return false;
			}
		}
	}
}

int main()
{

	srand((unsigned)time(NULL));
	int arrMatrix1[3][3], arrMatrix[3], OneMatrixResult = 0, TwoMatrixResult = 0;

	cout << "Matrix1:\n";
	FillMatrix(arrMatrix1, 3, 3);
	PrintMatrix(arrMatrix1, 3, 3);

	if (ScolarMatrex(arrMatrix1, 3, 3))
		cout << "\n\nYes: Matrix is identity.";
	else
		cout << "\n\nNot: Matrix arenot identity.";



	_getch();
	return 0;
}