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


int TotalMonthes(float LoanAmount, float NumbeOfMonthly)
{
	return (float)LoanAmount / NumbeOfMonthly;
}

int main()
{
	float LoanAmount = ReadPositiveNumber("Please the LoanAmount.");
	float NumbeOfMonthly = ReadPositiveNumber("Please the NumbeOfMonthly.");

	cout << "The Loan of Monthly: " << TotalMonthes(LoanAmount, NumbeOfMonthly);
	_getch();
	return 0;
}