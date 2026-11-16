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

int RandomNumber(int From, int To)
{
	int Num = rand() % (To - From + 1) + From;
	return Num;
}

void FillArrayWithRandomNumber(int arr[100], int &arrLength)
{
	arrLength = ReadPositiveNumber("Please, enter number of length.");
	for (int i = 0; i < arrLength; i++)
		arr[i] = RandomNumber(1, 100);
}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << "\t";
	cout << "\n";
}

short FindNumberPositionInArray(int NumThatSearch, int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		if (NumThatSearch == arr[i])
			return i;

	return -1;
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[100], arrLength;
	FillArrayWithRandomNumber(arr, arrLength);
	cout << "\nArray elements:\n\n";
	PrintArray(arr, arrLength);
	int NumThatSearch = ReadPositiveNumber("Please, enter Number that search.\n");
	short PositionNumber = FindNumberPositionInArray(NumThatSearch, arr, arrLength);

	if (PositionNumber == -1)
		cout << "The number is not found :-(\n";
	else
	{
		cout << "The number found at position: ";
		cout << PositionNumber << endl;
		cout << "The number found its order : ";
		cout << PositionNumber + 1 << endl;
	}
	_getch();
	return 0;
}

