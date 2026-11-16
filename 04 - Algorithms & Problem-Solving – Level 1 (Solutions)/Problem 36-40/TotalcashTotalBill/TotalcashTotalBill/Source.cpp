#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float ReadNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <= 0);
	return Num;
}

float CalculateRemainder(float TotalCash, float TotalBill)
{
	return TotalCash - TotalBill;
}
int main()
{
	float TotalCash = ReadNumber("Please enter the Totalcash");
	float TotalBill = ReadNumber("Please enter the totalbill");

	cout << "TotalCash = " << TotalCash << endl;
	cout << "TotalBill = " << TotalBill << endl;
	cout << "**************************\n";
	cout << "Result = " << CalculateRemainder(TotalCash, TotalBill) << endl;



	_getch();
	return 0;
}