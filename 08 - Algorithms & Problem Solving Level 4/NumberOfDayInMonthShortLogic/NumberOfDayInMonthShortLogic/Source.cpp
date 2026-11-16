#include<iostream>
#include<conio.h>
using namespace std;

short ReadYear()
{
	short Year = 0;
	cout << "Please enter a year to ckeck? ";
	cin >> Year;

	return Year;
}

short ReadMonth()
{
	short Month = 0;
	cout << "Please enter a Month to ckeck? ";
	cin >> Month;

	return Month;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year && 100 != 0) || (Year % 400 == 0));
}

short NumberOfDayInMonth(short Month, short Year)
{
	if (Month < 1 || Month > 12)
	{
		return 0;
	}

	int arrMonthDay[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrMonthDay[Month - 1];
}

int main()
{
	short Year = ReadYear();
	short Month = ReadMonth();

	cout << "\nMonth of Days   in Month [" << Month << "] is " << NumberOfDayInMonth(Month, Year) << endl;
	
	_getch();
	return 0;
}