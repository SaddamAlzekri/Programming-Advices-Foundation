#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <= 0);
	return Num;
}

int SumOfDigit(int Number, int DigitToCheck)
{
	int Remainder = 0, Counter = 0;
	cout << "\nOutPut\n\n";
	while (Number > 0)
	{
		Remainder = Number % 10;
		Number = Number / 10;
		if (Remainder == DigitToCheck)
			Counter++;
	}
	return Counter;
}

int main()
{
	int Number = ReadPositiveNumber("Please Enter The Digits.");
	int DigitToCheck = ReadPositiveNumber("Please Enter One Digit To Check.");


	cout << "\nDigit " << DigitToCheck << "Frequency is " << SumOfDigit(Number, DigitToCheck) << " Time(s)." << endl;

	_getch();
	return 0;
}