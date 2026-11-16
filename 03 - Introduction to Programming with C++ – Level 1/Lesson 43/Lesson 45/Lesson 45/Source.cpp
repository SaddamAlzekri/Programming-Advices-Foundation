#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

string YearMonthes(short Num1)
{
	if (Num1 == 1)
	{
		return "January";
	}
	else if (Num1 == 2)
	{
		return "February";
	}
	else if (Num1 == 3)
	{
		return "March";
	}
	else if (Num1 == 4)
	{
		return "April";
	}
	else if (Num1 == 5)
	{
		return "May";
	}
	else if (Num1 == 6)
	{
		return "June";
	}
	else if (Num1 == 7)
	{
		return "July";
	}
	else if (Num1 == 8)
	{
		return "August";
	}
	else if (Num1 == 9)
	{
		return "September";
	}
	else if (Num1 == 10)
	{
		return "October";
	}
	else if (Num1 == 11)
	{
		return "November";
	}
	else if (Num1 == 12)
	{
		return "December";
	}
	else
	{
		return "Wrong day\n";
	}
}

int main()
{
	short Num1;
	cout << "Please, enter the num1.\n";
	cin >> Num1;
	cout << "***********************\n";
	cout << YearMonthes(Num1) << endl;
	_getch();
	return 0;
}