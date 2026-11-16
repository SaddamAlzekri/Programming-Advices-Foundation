#include<iostream>
#include<conio.h>
#include<string>
#include<stdlib.h>
#include<time.h>

using namespace std;

int ReadRandomNumber(int From, int To)
{
	int Num = 0;
	//Generate Random Numbers
	Num = rand() % (To - From + 1) + From;
	return Num;
}

void FillarrayWithRandomNumbers(int arr1[100], int& arrLength)
{
	cout << "\nEnter number of length: \n";
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
		arr1[i] = ReadRandomNumber(1, 100);
}

void PrintArray(int arr1[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr1[i] << "\t";
}

void CopyArray(int arrSource[100], int arrDestination[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		arrDestination[i] = arrSource[i];
}

int main()
{
	int arr1[100], arr2[100], arrLength;
	FillarrayWithRandomNumbers(arr1, arrLength);
	cout << "\nArray 1 Elements: \n";
	PrintArray(arr1, arrLength);
	CopyArray(arr1, arr2, arrLength);
	cout << "\nArray 2 Elements: \n";
	PrintArray(arr2, arrLength);
	_getch();
	return 0;
}