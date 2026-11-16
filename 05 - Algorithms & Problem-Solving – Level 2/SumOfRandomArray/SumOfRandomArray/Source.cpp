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

void FillarrayWithRandomNumbers(int arr[100], int& arrLength)
{
	cout << "\nEnter number of length: \n";
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = ReadRandomNumber(1, 100);
	}
}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << "\t";
}

int SumArray(int arr[100], int arrLength)
{
	int Sum = 0;
	for (int i = 0; i < arrLength; i++)
	{
		Sum += arr[i];
	}
	return Sum;
}

int main()
{
	int arr[100], arrLength;
	FillarrayWithRandomNumbers(arr, arrLength);
	cout << "\n0Array Elements: \n";
	PrintArray(arr, arrLength);
	cout << "\nSum of all number is : ";
	cout << SumArray(arr, arrLength) << endl;
	_getch();
	return 0;
}