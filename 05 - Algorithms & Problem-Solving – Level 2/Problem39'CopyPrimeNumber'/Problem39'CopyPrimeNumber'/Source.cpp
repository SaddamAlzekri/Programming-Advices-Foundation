#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

enum enCheckNumber
{
	Prime = 1, NotPrime = 2
};

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

enCheckNumber CheckPrime(int Number)
{
	int M = round(Number / 2);
	for (int Counter = 2; Counter <= M; Counter++)
	{
		if (Number % Counter == 0)
			return enCheckNumber::NotPrime;
	}
	return enCheckNumber::Prime;
}

void AddArrayElement(int Number, int arr2[100], int &arr2Length)
{
	arr2[arr2Length] = Number;
	arr2Length++;
}
void CopyPrimeNumbers(int arr[100], int arr2[100], int arrLength, int &arr2Length)
{
	for (int i = 0; i < arrLength; i++)
	{
		if (CheckPrime(arr[i]) == enCheckNumber::Prime)
		{
			AddArrayElement(arr[i], arr2, arr2Length);
		}
	}

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

	CopyPrimeNumbers(arr, arr2, arrLength, arr2Length);

	cout << "\nArray 1 elements after copy: \n";
	PrintArray(arr2, arr2Length);

	_getch();
	return 0;
}