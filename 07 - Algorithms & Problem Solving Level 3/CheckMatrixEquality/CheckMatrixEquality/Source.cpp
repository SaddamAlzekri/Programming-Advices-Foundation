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

int SumMatrix(int arr[3][3], short Rows, short Cols)
{
	int SumMatrix = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			SumMatrix += arr[i][j];
		}
	}
	return SumMatrix;
}

bool AreEqualMatrix(int Matrix1[3][3], int Matrix2[3][3], short Rows, short Cols)
{
	return (SumMatrix(Matrix1, Rows, Cols) == SumMatrix(Matrix2, Rows, Cols));
}

int main()
{
	srand((unsigned)time(NULL));
	int arrMatrix1[3][3], arrMatrix2[3][3], OneMatrixResult = 0, TwoMatrixResult = 0;
	
	FillMatrix(arrMatrix1, 3, 3);
	cout << "Matrix1:\n";
	PrintMatrix(arrMatrix1, 3, 3);

	FillMatrix(arrMatrix2, 3, 3);
	cout << "\nMatrix2:\n";
	PrintMatrix(arrMatrix2, 3, 3);


	if (AreEqualMatrix(arrMatrix1, arrMatrix2, 3, 3))
		cout << "\n\nYes: Matrix are Equal.\n";
	else
		cout << "\n\nNo: Matrix are Not Equal.\n";

	_getch();
	return 0;
}