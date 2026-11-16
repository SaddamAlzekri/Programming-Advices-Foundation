#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;

	} while (Num <= 0);
	return Num;
}

float TotalBillAfterSeervicesAndTax(float TotalBill)
{
	TotalBill *= 1.1;
	TotalBill *= 1.16;

	return TotalBill;
}

int main()
{
	float TotalBill = ReadPositiveNumber("Please enter the Number.");
	cout << "TotalBill = " << TotalBill << endl;
	cout << "TotalBill after the service fee and sales tax = " << TotalBillAfterSeervicesAndTax(TotalBill);

	_getch();
	return 0;
}