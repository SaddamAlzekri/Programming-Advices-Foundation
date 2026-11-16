#include<iostream>
#include<conio.h>
#include<string>
#include<stdlib.h>
#include<time.h>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Num = 0;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num < 0);
	return Num;
}

int ReadRandomNumber(int To, int From)
{
	return (rand() % (To - From + 1) + From);
}

void FillArrayWithRandomNumbers(int Array[100], int ArrLength)
{
	for (int i = 0; i < ArrLength; i++)
	{
		Array[i] = ReadRandomNumber(100, 1);
	}
}

void PrintArray(int Arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		cout << Arr[i] << "\t";
	}
	cout << "\n";
}

void SumOfArray1andArray2(int arr1[100], int arr2[100], int sumArr[100],int arrLength)
{
	cout << "\nSum of array1 and array2 elements: \n";
	for (int i = 0; i < arrLength; i++)
	{
		sumArr[i] = arr1[i] + arr2[i];
	}
}

int main()
{
	srand((unsigned)time(NULL));
	int arr1[100], arr2[100], sumArr[100];
	int arrLength = ReadPositiveNumber("How many elements?");
	FillArrayWithRandomNumbers(arr1, arrLength);
	FillArrayWithRandomNumbers(arr2, arrLength);
	cout << "\nArray 1 elements:\n";
	PrintArray(arr1, arrLength);
	cout << "\nArray 2 elements:\n";
	PrintArray(arr2, arrLength);
	SumOfArray1andArray2(arr1, arr2, sumArr, arrLength);
	cout << "\nSum of all array1 and array2:\n";
	PrintArray(sumArr, arrLength);
	_getch();
	return 0;
}