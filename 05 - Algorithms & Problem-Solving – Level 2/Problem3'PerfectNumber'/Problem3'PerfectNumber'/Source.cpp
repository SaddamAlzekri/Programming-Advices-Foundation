#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int readPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <= 0);
	return Num;
}

bool checkPrefectNumber(int Num)
{
	int Sum = 0;
	for (int i = 1; i < Num; i++)
	{
		if (Num % i == 0)
		{
			Sum += i;
		}
	}
	return Num == Sum;
}

void PrintPrefectNumber(int Num)
{
	if (checkPrefectNumber(Num))
		cout << Num << " is Perfect" << endl;
	else
		cout << Num << " is Not Perfect" << endl;
}

int main()
{
	int Num = readPositiveNumber("Please Enter the Prime Number.");
	PrintPrefectNumber(Num); 
	_getch();
	return 0;
}