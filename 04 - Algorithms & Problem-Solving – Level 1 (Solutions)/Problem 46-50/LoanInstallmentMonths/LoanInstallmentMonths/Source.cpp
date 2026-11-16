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
	} while (Num < 0);
	return Num;
}


int TotalMonthes(float LoanAmount, float MonthlyPayMent)
{
	return (float)LoanAmount / MonthlyPayMent;
}

int main()
{
	float LoanAmount = ReadPositiveNumber("Please the LoanAmount.");
	float MonthlyPayMent = ReadPositiveNumber("Please the MonthlyPayMent.");

	cout << "The TotalMonthly: " << TotalMonthes(LoanAmount, MonthlyPayMent);
	_getch();
	return 0;
}