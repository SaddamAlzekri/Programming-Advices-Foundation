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
			cout <<arr[i][j] << setw(5);
		}
		cout << "\n";
	}
}

bool isExitNumberInMatrix(int Matrix[3][3],int Number, int Rows, int Cols)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			if (Matrix[i][j] == Number)
				return true;
		}
	}
	return false;
}
int main()
{
	srand((unsigned)time(NULL));
	int arrMatrix[3][3], Number;

	FillMatrixWithRandomNumbers(arrMatrix, 3, 3);
	cout << "The following is a 3x3 random matrix:\n";
	PrintMatrix(arrMatrix, 3, 3);
	
	cout << "\nPlease enter the number to look for in matrix? ";
	cin >> Number;

	if (isExitNumberInMatrix(arrMatrix, Number, 3, 3))
		cout << "\nYes: it is there\n";
	else
		cout << "\nNo: it is not there";
	_getch();
	return 0;
}