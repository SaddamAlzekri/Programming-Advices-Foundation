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

int SumOfDigit(int Num)
{
	int Remainder = 0, Sum = 0;
	while (Num > 0)
	{
		Remainder = Num % 10;
		Num = Num / 10;
		Sum += Remainder;
	}

	return Sum;
}

int main()
{
	string Str = "Please Enter The Digits.";
	cout << "\nSum Of Digits = " << SumOfDigit(ReadPositiveNumber(Str)) << endl;

	_getch();
	return 0;
}