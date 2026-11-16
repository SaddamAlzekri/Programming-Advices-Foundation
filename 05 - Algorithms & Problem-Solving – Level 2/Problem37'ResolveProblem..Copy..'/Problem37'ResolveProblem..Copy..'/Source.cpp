#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int RandomNumber(int From, int To)
{
	return rand() % (To - From + 1) + From;
}

void FillArrayWithRandomNumbers(int arr[100], int &arrLength)
{
	cout << "Please enter numner of length.\n";
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
		arr[i] = RandomNumber(1, 100);
}

void AddElements(int Number, int arr2[100], int &arr2Length)
{
	arr2[arr2Length] = Number;
	arr2Length++;
}

void CopyArrayUsingAddArrayElement(int arr[100], int arr2[100], int arrLength, int &arr2Length)
{
	for (int i = 0; i < arrLength; i++)
		AddElements(arr[i], arr2, arr2Length);
}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << "\t";
}

int main()
{
	int arr[100], arr2[100], arrLength = 0, arr2Length = 0;
	FillArrayWithRandomNumbers(arr, arrLength);

	cout << "\nArray 1 elements: \n";
	PrintArray(arr, arrLength);

	CopyArrayUsingAddArrayElement(arr, arr2, arrLength, arr2Length);

	cout << "\nArray 1 elements after copy: \n";
	PrintArray(arr2, arrLength);

	_getch();
	return 0;
}