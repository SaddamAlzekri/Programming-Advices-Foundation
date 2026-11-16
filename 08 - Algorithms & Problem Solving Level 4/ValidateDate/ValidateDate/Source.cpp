#include<iostream>
#include<conio.h>
#include<ctime>

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
	cout << "please enter a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month = 0;
	cout << "please enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year = 0;
	cout << "please enter a Year? ";
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

short NumberOfMonthDays(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;

	short arrMonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrMonthDays[Month - 1];
}

bool isDayOfMonthCorrect(short Day, short Month, short Year)
{
	if (Day <= NumberOfMonthDays(Month, Year) && Day > 0)
	{
		return true;
	}
	return false;
}

bool isMonthCorrect(short Month)
{
	return (Month > 0 && Month < 13) ? true : false;
}

bool isYearCorrect(short Year)
{
	time_t t = time(0);
	tm* now = localtime(&t);
	if (now->tm_year + 1900 >= Year && Year > 0)
		return true;
	return false;
}

bool ValidateDate(short Day, short Month, short Year)
{
	if (isDayOfMonthCorrect(Day, Month, Year) == true && isMonthCorrect(Month) == true && isYearCorrect(Year) == true)
	{
		return true;
	}
	return false;
}

int main()
{
	sDate Date = ReadFullDate();

	if (ValidateDate(Date.Day, Date.Month, Date.Year))
		cout << "\n\nYes, Date is a valide date.\n";
	else 
		cout << "\n\nNo, Date is a Not valide date.\n";

	_getch();
	return 0;
}