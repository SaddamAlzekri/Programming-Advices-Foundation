#include<iostream>
#include<conio.h>
using namespace std;
enum EnCheckNumber {odd = 1, even = 2};
int ReadNumber()
{
	int Number;
	cout << "Please enter number.\n";
	cin >> Number;
	return Number;
}

EnCheckNumber CheckNumber(int Number)
{
	int Result = Number % 2;

	if (Result == 0)
		return EnCheckNumber::even;
	else
		return EnCheckNumber::odd;
}

void PrintNumer(EnCheckNumber Number)
{
	if (Number == EnCheckNumber::even)
		cout << "Even Number\n";
	else
		cout << "Odd Number\n";
}

int main()
{
	PrintNumer(CheckNumber(ReadNumber()));
	_getch();
	return 0;
}