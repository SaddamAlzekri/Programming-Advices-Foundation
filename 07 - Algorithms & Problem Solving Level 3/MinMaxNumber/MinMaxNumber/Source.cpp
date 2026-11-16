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
			arr[i][j] = RandomNumber(80, 100);
		}
	}
}

void PrintMatrix(int arr[3][3], short Rows, short Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			cout << " " << arr[i][j] << "   ";
		}
		cout << "\n";
	}
}

short MinNumber(int Matrix[3][3], short Rows, short Cols)
{
	int Min = Matrix[0][0];
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (Matrix[i][j] < Min)
			{
				Min = Matrix[i][j];
			}
		}
	}
	return Min;
}

short MaxNumber(int Matrix[3][3], short Rows, short Cols)
{
	int Max = Matrix[0][0];
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (Matrix[i][j] > Max)
			{
				Max = Matrix[i][j];
			}
		}
	}
	return Max;
}

int main()
{
	srand((unsigned)time(NULL));

	int arrMatrix[3][3];
	short CounterFor = 0;

	FillMatrixWithRandomNumbers(arrMatrix, 3, 3);
	cout << "Matrix\n";
	PrintMatrix(arrMatrix, 3, 3);
	cout << "\nMiniMum Number is :" << MinNumber(arrMatrix, 3, 3);
	cout << "\nMaxMum Number is  :" << MaxNumber(arrMatrix, 3, 3);
	_getch();
	return 0;
}