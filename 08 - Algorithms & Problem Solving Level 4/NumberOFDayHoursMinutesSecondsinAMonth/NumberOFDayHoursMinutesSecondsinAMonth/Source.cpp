#include<iostream>
#include<conio.h>
using namespace std;

short ReadYear()
{
	short YearNumber = 0;
	cout << "Please enter the Number Of Year? ";
	cin >> YearNumber;

	return YearNumber;
}

short ReadMonth()
{
	short MonthNumber = 0;
	cout << "Please enter the Number Of Month? ";
	cin >> MonthNumber;

	return MonthNumber;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfDayInMonth(short Month, short Year)
{
	if (Month < 0 || Month > 12)
	{
		return 0;
	}
	if (Month == 2)
	{
		return (isLeapYear(Year)) ? 29 : 28;
	}

	int arrNum[7] = { 1, 3, 5, 7, 8, 10, 12 };

	for (short i = 0; i < 7; i++)
	{
		if (arrNum[i] == Month)
			return 31;
	}
	
	return 30;
}

short NumberOfHoursInMonth(short Month, short Year)
{
	return NumberOfDayInMonth(Month, Year) * 24;
}

int NumberOfMinutesInMonth(short Month, short Year)
{
	return NumberOfHoursInMonth(Month, Year) * 60;
}

int NumberOfSecondsInMonth(short Month, short Year)
{
	return NumberOfMinutesInMonth(Month, Year) * 60;
}

int main()
{
	short Year = ReadYear();
	short Month = ReadMonth();

	cout << "Number Of Day       in Month [" << Month << "] is : ";
	cout << NumberOfDayInMonth(Month, Year) << endl;

	cout << "Number Of Hours     in Month [" << Month << "] is : ";
	cout << NumberOfHoursInMonth(Month, Year) << endl;

	cout << "Number Of Minutes   in Month [" << Month << "] is : ";
	cout << NumberOfMinutesInMonth(Month, Year) << endl;

	cout << "Number Of Seconds   in Month [" << Month << "] is : ";
	cout << NumberOfSecondsInMonth(Month, Year) << endl;

	_getch();
	return 0;
}