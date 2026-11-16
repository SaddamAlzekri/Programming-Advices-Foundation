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

int isPalindromMatrix(int Matrix2[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (Matrix2[i][j] != Matrix2[i][Cols - 1 - j])
				return false;
		}
	}
	return true;
}

int main()
{
	srand((unsigned)time(NULL));

	int arrMatrix[3][3], arrIsPalindromeMatrix2[3][3];
	int arrReadyMatrix[3][3] = { {1, 4, 1}, {3, 77, 3}, { 9, 12, 9} };
	short CounterFor = 0;

	/*FillMatrixWithRandomNumbers(arrMatrix, 3, 3);
	cout << "Matrix\n";
	PrintMatrix(arrMatrix, 3, 3);

	PalindromMatrix(arrMatrix, arrIsPalindromeMatrix2, 3, 3);*/

	PrintMatrix(arrReadyMatrix, 3, 3);

	if (isPalindromMatrix(arrIsPalindromeMatrix2, 3, 3))
		cout << "\nYes: Matrix is Palindrome";
	else
		cout << "\nNot: Matrix isnot Palindrome";

	_getch();
	return 0;
}