#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Number;
	do
	{
		cout << Message << endl;
		cin >> Number;
	} while (Number <= 0);
	return Number;
}

int ReverceNumber(int Number)
{
	int Remainder = 0, Number2 = 0;
	while (Number > 0)
	{
		Remainder = Number % 10;
		Number = Number / 10;
		Number2 = Number2 * 10 + Remainder;
	}
	return Number2;
}

bool PrintPolindromNumber(int Number)
{
	return ReverceNumber(Number) == Number;
}

int main()
{
	int Number = ReadPositiveNumber("Please Enter The Number.");
	if (PrintPolindromNumber(Number))
		cout << "Yes, It is Palindrom a Number.\n";
	else
		cout << "No, It is Not a Palindrom Number.\n";

	_getch();
	return 0;
}