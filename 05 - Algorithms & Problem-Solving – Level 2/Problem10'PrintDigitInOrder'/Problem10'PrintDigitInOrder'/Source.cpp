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

int RevercePositivenumber(int Num)
{
	int Remainder = 0, Number2 = 0;
	while (Num > 0)
	{
		Remainder = Num % 10;
		Num = Num / 10;
		Number2 = Number2 * 10 + Remainder;
	}
	return Number2;
}

void PrintDigit(int Num)
{
	int Remainder = 0;
	while (Num > 0)
	{
		Remainder = Num % 10;
		Num = Num / 10;
		cout << Remainder << endl;
	}
}

int main()
{
	string Str = "Please Enter The Digits.";
	PrintDigit(RevercePositivenumber(ReadPositiveNumber(Str)));

	_getch();
	return 0;
}