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
			cout <<" "<<arr[i][j] << "   ";
		}
		cout << "\n";
	}
}

bool isExitNumberInMatrix(int Matrix[3][3], int Matrix2[3][3], int Number, int Rows, int Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			if (Number == Matrix2[i][j])
				return true;
		}
	}
	return false;
}
void PrintExitNumberInMatrix(int Matrix[3][3],int Matrix2[3][3], int Rows, int Cols)
{
	int Counter = 0;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			int Number = Matrix[i][j];
			if (isExitNumberInMatrix(Matrix, Matrix2, Number, Rows, Cols))
				cout << "  " << Number << setw(5);
		}
	}
}


int main()
{
	srand((unsigned)time(NULL));

	int arrMatrix[3][3], arrMatrix2[3][3], Matrix[9];
	short CounterFor = 0;

	FillMatrixWithRandomNumbers(arrMatrix, 3, 3);
	cout << "Matrix\n";
	PrintMatrix(arrMatrix, 3, 3);

	FillMatrixWithRandomNumbers(arrMatrix2, 3, 3);
	cout << "\nMatrix2\n";
	PrintMatrix(arrMatrix2, 3, 3);


	cout << "\nEntersected Number are:-\n";
	PrintExitNumberInMatrix(arrMatrix, arrMatrix2, 3, 3);

	_getch();
	return 0;
}