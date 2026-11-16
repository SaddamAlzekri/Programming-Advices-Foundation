#include<iostream>
#include<conio.h>
#include<string>
#include<time.h>
#include<stdlib.h>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num < 1);
	return Num;
}

void Swap(int &A, int &B)
{
	int Temp = 0;
	Temp = A;
	A = B;
	B = Temp;
}

int RandomNumber(int From, int To)
{
	return rand() % (To - From + 1) + From;
}

void FillArrayeith1ToN(int Array[], int arrLength)
{
	cout << "\nArray elements after shuffle:\n";
	for (int i = 0; i < arrLength; i++)
		Array[i] = RandomNumber(1, arrLength);
}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << "\t";
}

void ShuffleArray(int Array[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		Swap(Array[RandomNumber(1, arrLength) - 1], 
			Array[RandomNumber(1, arrLength) - 1]);
	}
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[100];
	int arrLength = ReadPositiveNumber("Please enter the length:");
	FillArrayeith1ToN(arr, arrLength);
	cout << "\nArray elements before shuffle:\n";
	PrintArray(arr, arrLength);
	ShuffleArray(arr, arrLength);
	cout << "\nArray elements after shuffle:\n";
	PrintArray(arr, arrLength);
	_getch();
	return 0;
}

