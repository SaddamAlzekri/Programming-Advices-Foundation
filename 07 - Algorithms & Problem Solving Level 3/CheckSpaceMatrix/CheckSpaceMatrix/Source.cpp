#include<iostream>
#include<conio.h>
#include<iomanip>
#include<time.h>
using namespace std;

void PrintMatrix(int arrMatrix[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			printf(" %0*d  ", 2, arrMatrix[i][j]);
		}
		cout << "\n";
	}
}

int CheckSparceMatrix(int arrMatrix[3][3],int Number, int Rows, int Cols)
{	
	int Counter = 0;
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			if (arrMatrix[i][j] == Number)
				Counter++;
		}
	}
	return Counter;
}

bool isSparceMatrix(int arrMatrix[3][3], int Rows, int Cols)
{
	short SparceNumber = Rows * Cols;
	return (CheckSparceMatrix(arrMatrix, 0, 3, 3) > SparceNumber / 2);
}
int main()
{

	srand((unsigned)time(NULL));
	int arrMatrix1[3][3] = { { 1, 0, 4 }, { 0, 7, 0 }, { 9, 7, 0 } };
	int arrMatrix2[3][3] = { { 0, 0, 4 }, { 1, 7, 0 }, { 9, 0, 0 } };
	int CounterZero = 0, CounterOtherNumber = 0;

	//When is number of 0 bigger than other number the array is a sparce matrix

	cout << "Matrix1:\n";
	PrintMatrix(arrMatrix1, 3, 3);


	if (isSparceMatrix(arrMatrix1, 3, 3))
		cout << "Yes: It is sparce.";
	else
		cout << "No: It is not sparce.";

	_getch();
	return 0;

}