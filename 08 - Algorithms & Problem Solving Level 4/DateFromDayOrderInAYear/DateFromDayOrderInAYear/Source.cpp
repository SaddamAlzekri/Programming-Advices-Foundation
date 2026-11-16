#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 100);
}

short NumberOfMonthDay(short Month, short Year)
{
	if (Month == 2)
	{
		return (isLeapYear(Year)) ? 29 : 28;
	}

	short arrMonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return ((Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrMonthDays[Month - 1]);
}

short NumberOfDayForDate(short Day, short Month, short Year)
{
	short SumOfDays = 0;
	for (short i = 1; i <= Month - 1; i++)
	{
		SumOfDays += NumberOfMonthDay(i, Year);
	}
	SumOfDays += Day;
	return SumOfDays;
}

struct sDate
{
	short Year;
	short Month;
	short Day;
};

sDate GetDateFromDayOrderInAYear(short DateOrderInYear, short Year)
{
	sDate Date;
	short Remainder = DateOrderInYear;
	short DaysMonth = 0;

	Date.Year = Year;
	Date.Month = 1;
	while (true)
	{
		DaysMonth = NumberOfMonthDay(Date.Month, Year);

		if (Remainder > DaysMonth)
		{
			Remainder -= DaysMonth;
			Date.Month++;
		}
		else
		{
			Date.Day = Remainder;
			break;
		}
	}
	return Date;
}

short ReadDay()
{
	short Day;
	cout << "Please enter a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month;
	cout << "Please enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short year;
	cout << "Please enter a year? ";
	cin >> year;

	return year;
}

int main()
{
	short Day, Month, Year;

	Day = ReadDay();
	Month = ReadMonth();
	Year = ReadYear();
	short DateOrderInYear = NumberOfDayForDate(Day, Month, Year);
	cout << "\n\nNumberOf Days From the beginner of the years is : " << DateOrderInYear;

	sDate Date;
	Date = GetDateFromDayOrderInAYear(DateOrderInYear, Year);

	cout << "\nDate for [" << DateOrderInYear << "] is: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
	_getch();
	return 0;
}