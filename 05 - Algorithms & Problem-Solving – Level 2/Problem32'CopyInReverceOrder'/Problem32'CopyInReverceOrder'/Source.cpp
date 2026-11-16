#include<iostream>
#include<conio.h>
#include<string>
#include<time.h>
#include<stdlib.h>
using namespace std;

int RandomNumber(int From,int To )
{
	return rand() % (To - From + 1) + From;
}

void FillArrayWithRandomNumber(int arr[], int &arrLength)
{
	cout << "\nPlese enter number of elements:\n";
	cin >> arrLength;
	for (size_t i = 0; i < arrLength; i++)
		arr[i] = RandomNumber(1, 100);

}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << "\t";
}

void CopyArrayInReverceOrder(int arr[100], int arr2[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		arr2[i] = arr[arrLength - 1 - i];
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[100], arrLength;
	FillArrayWithRandomNumber(arr, arrLength);
	int arr2[100];
	CopyArrayInReverceOrder(arr, arr2, arrLength);
	cout << "\nArray 1 elements:\n";
	PrintArray(arr, arrLength);
	cout << "\nArray 2 elements after copy:\n";
	PrintArray(arr2, arrLength);
	_getch();
	return 0;
}

