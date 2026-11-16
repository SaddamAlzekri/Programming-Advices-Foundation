#include<iostream>
#include<Conio.h>
#include<string>
using namespace std;

int RandomNumber(int From, int To)
{
	return rand() % (To - From + 1) + From;
}

void FillArray(int arr[6], int &arrLength)
{
	cout << "Please enter the number of length:\n";
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
		arr[i] = RandomNumber(1, 100);
}

void PrintArray(int arr[6], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << "\t";
}

void CheckEvenNumber(int arr[100], int arr2[100], int arrLength, int &arr2Length)
{
	for (int i = 0; i < arrLength; i++)
	{
		if (arr[i] % 2 == 0)
		{
			arr2[arr2Length] = arr[i];
			arr2Length++;
		}
	}
}

int main()
{
	int arr[6], arr2[6], arrLength = 0, arr2Length = 0;
	FillArray(arr, arrLength);
	cout << "Output\n";
	cout << "Array Elements:\n";
	PrintArray(arr, arrLength);
	CheckEvenNumber(arr, arr2, arrLength, arr2Length);
	cout << "\nEven Number count is:\n";
	PrintArray(arr2, arr2Length);
	cout << "\nEven Number count is: " << arr2Length << "\n";

	_getch();
	return 0;
}