#include<iostream>
#include<conio.h>
#include<string>
#include<time.h>
#include<stdlib.h>
using namespace std;

enum enCheckType
{ SmallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };

int RandomNumber(int From, int To)
{
	int Number = rand() % (To - From + 1) + From;
	return Number;
}

char GetRandomCharacter(enCheckType CharType)
{
	switch (CharType)
	{
	case enCheckType::SmallLetter:
		return char(RandomNumber(97, 122));
		break;
	case enCheckType::CapitalLetter:
		return char(RandomNumber(65, 90));
		break;
	case enCheckType::SpecialCharacter:
		return char(RandomNumber(33, 47));
		break;
	case enCheckType::Digit:
		return char(RandomNumber(48, 57));
		break;
	}

}

string GenerateWord(enCheckType charType, int arrLength)
{
	string Word = "";
	for (int i = 0; i < arrLength; i++)
		Word += GetRandomCharacter(charType);
	return Word;
}

string GenerateKey()
{
	string Key = "";

	Key += GenerateWord(enCheckType::CapitalLetter, 4) + "-";
	Key += GenerateWord(enCheckType::CapitalLetter, 4) + "-";
	Key += GenerateWord(enCheckType::CapitalLetter, 4) + "-";
	Key += GenerateWord(enCheckType::CapitalLetter, 4);

	return Key;
}

void FillArray(string arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		arr[i] = GenerateKey();
}

void PrintArray(string arr[100], int arrLength)
{
	cout << "\nArray elements:\n\n";
	for (size_t i = 0; i < arrLength; i++)
		cout <<"\nArray["<<i<<"] : "<< arr[i] << "\t";

	cout << "\n";
}

int readPositiveNumber(string Message)
{
	int Num = 0;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num < 1);
	return Num;
}

int main()
{
	srand((unsigned)time(NULL));
	string arr[100];
	int arrLength = readPositiveNumber("Please, enter number of length.");
	FillArray(arr, arrLength);
	PrintArray(arr, arrLength);

	_getch();
	return 0;
}

