#include<iostream>
#include<conio.h>
#include<string>
#include<stdlib.h>
#include<time.h>
using namespace std;

enum PrimeOrNotPrime{ Prime = 1, NotPrime = 2 };

int ReadRandomNumber(int From, int To)
{
	int Num = rand() % (To - From + 1) + From;
	return Num;
}

void ReadToArray(int arr[100], int& arrLength)
{
	cout << "\nEnter number of length:\n";
	cin >> arrLength;
	cout << "Array 1 Element:\n";
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = ReadRandomNumber(1, 100);
	}
}

PrimeOrNotPrime CheckPrime(int Number)
{
	int M = round(Number / 2);
	for (int i = 2; i <= M; i++)
	{
		if (Number % i == 0)
			return PrimeOrNotPrime::NotPrime;
	}
	return PrimeOrNotPrime::Prime;
}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		cout << arr[i] << "\t";
	}
}

void CopyOnlyPrimeNumbers(int arr1[100], int arr2[100], int arrLength, int &arr2Length)
{
	int CountNumber = 0;
	for (int i = 0; i < arrLength; i++)
	{
		if (CheckPrime(arr1[i]) == PrimeOrNotPrime::Prime)
		{
			arr2[CountNumber] = arr1[i];
			CountNumber++;
		}
	}
	arr2Length = --CountNumber;
}

int main()
{
	srand((unsigned)time(NULL));
	int arr1[100], arrLength;
	ReadToArray(arr1, arrLength);
	cout << "\nArray 1 elements:\n";
	PrintArray(arr1, arrLength);
	int arr2[100], arr2Length;
	CopyOnlyPrimeNumbers(arr1, arr2, arrLength, arr2Length);
	cout << "\nPrime Numbers in Array2:\n";
	PrintArray(arr2, arr2Length);
	_getch();
	return 0;
}