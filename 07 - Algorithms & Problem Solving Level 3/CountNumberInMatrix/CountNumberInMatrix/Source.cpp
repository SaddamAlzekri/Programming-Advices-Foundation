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

short CountNumberInMatrix(int arrMatrix1[3][3], int Number, short Rows, short Cols)
{
	int Counter = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (Number == arrMatrix1[i][j])
				Counter++;
		}
	}
	return Counter;
}

int main()
{

	srand((unsigned)time(NULL));
	int arrMatrix1[3][3], Number, OneMatrixResult = 0, TwoMatrixResult = 0;

	cout << "Matrix1:\n";
	FillMatrix(arrMatrix1, 3, 3);
	PrintMatrix(arrMatrix1, 3, 3);

	cout << "Enter the Number to count the Matrix?\n";
	cin >> Number;

	cout << "NumbSer " << Number << " Count in Matrix is " << CountNumberInMatrix(arrMatrix1, Number, 3, 3);

	
	_getch();
	return 0;

}