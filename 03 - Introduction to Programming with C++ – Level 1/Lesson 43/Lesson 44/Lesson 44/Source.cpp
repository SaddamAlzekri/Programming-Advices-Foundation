#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

string WeekDay(short Num1)
{
	if (Num1 == 1)
	{
		return "Sunday";
	}
	else if (Num1 == 2)
	{
		return "Monday";
	}
	else if (Num1 == 3)
	{
		return "Tuesday";
	}
	else if (Num1 == 4)
	{
		return "Wednesday";
	}
	else if (Num1 == 5)
	{
		return "Thursday";
	}
	else if (Num1 == 6)
	{
		return "Friday";
	}
	else if (Num1 == 7)
	{
		return "Saturday";
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
	cout << WeekDay(Num1) << endl;
	_getch();
	return 0;
}