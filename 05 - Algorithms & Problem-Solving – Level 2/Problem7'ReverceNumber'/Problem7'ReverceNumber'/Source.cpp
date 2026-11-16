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
	int Remainder = 0, Number = 0;
	cout << "\nOutPut\n\n";
	cout << "Reverce is: \n";
	while (Num > 0)
	{
		Remainder = Num % 10;
		Num = Num / 10;
		Number = Number * 10 + Remainder;
	}
	return Number;
}

int main()
{
	string Str = "Please Enter The Digits.";
	cout << "\nReverce is:\n" << SumOfDigit(ReadPositiveNumber(Str)) << endl;;

	_getch();
	return 0;
}