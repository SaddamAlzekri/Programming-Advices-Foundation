
// Anothor Way For Answer this Quastion

#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

struct sDate
{
	short Day;
	short Month;
	short Year;
};

short ReadDay()
{
	short Day = 0;
	cout << "PleaSe enter a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month = 0;
	cout << "PleaSe enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year = 0;
	cout << "PleaSe enter a Year? ";
	cin >> Year;

	return Year;
}

sDate ReadFullDate()
{
	sDate Date;
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();

	return Date;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfMonthDay(short Month, short Year)
{
	if (Month < 1 || Month > 12)
		return 0;

	short MonthDay[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : MonthDay[Month - 1];
}

bool isValidateDate(sDate Date)
{
	if (Date.Day < 1 || Date.Day > 31)
		return false;
	if (Date.Month < 1 || Date.Day > 12)
		return false;

	if (Date.Month == 2)
	{
		if (isLeapYear(Date.Year))
		{
			if (Date.Day > 29)
				return false;
			else
				return false;
		}
	}

	int OverLapPeriods = NumberOfMonthDay(Date.Month, Date.Year);

	if (Date.Day > OverLapPeriods)
		return false;

	return true;
}
int main()
{
	sDate Date = ReadFullDate();

	if (isValidateDate(Date))
	{
		cout << "Yes, Date is a valide date\n";
	}
	else
	{
		cout << "No, Date is Not a valide date\n";
	}
	_getch();
	return 0;
}