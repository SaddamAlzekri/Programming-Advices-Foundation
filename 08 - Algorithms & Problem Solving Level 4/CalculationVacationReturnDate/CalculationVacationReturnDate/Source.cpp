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
	short Day;
	cout << "Please enter  a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month;
	cout << "Please enter  a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year;
	cout << "Please enter  a Year? ";
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

short VacationDays()
{
	short vVacationDays = 0;
	cout << "\n\nPlease enter vacation days? ";
	cin >> vVacationDays;

	return vVacationDays;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfMonthDays(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;

	short MonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : MonthDays[Month - 1];
}

bool isLastDayOfMonth(short Day, short Month, short Year)
{
	return (Day == NumberOfMonthDays(Month, Year));
}

bool isLastMonthOfYear(short Month)
{
	return (Month == 12);
}

sDate increaseOneDay(sDate Date)
{
	if (isLastDayOfMonth(Date.Day, Date.Month, Date.Year))
	{
		if (isLastMonthOfYear(Date.Month))
		{
			Date.Day = 1;
			Date.Month = 1;
			Date.Year++;
		}
		else
		{
			Date.Day = 1;
			Date.Month++;
		}
	}
	else
	{
		Date.Day++;
	}

	return Date;
}

short DayOfWeekOrder(short Day, short Month, short Year)
{
	short a, y, m;

	a = (14 - Month) / 12;
	y = Year - a;
	m = Month + (12 * a) - 2;

	return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

bool isWeekEnd(sDate Date)
{
	return !(DayOfWeekOrder(Date.Day, Date.Month, Date.Year) == 6 || DayOfWeekOrder(Date.Day, Date.Month, Date.Year) == 5);
}

sDate VacationDate(sDate Date, short VacationDays)
{

	short Days = 0;

	while (Days <= VacationDays)
	{
		Date = increaseOneDay(Date);
		if (isWeekEnd(Date))
		{
			Days++;
		}
	}

	return Date;
}

string ShortMonthName(short NumberOfWeekOrder)
{
	string shortWeekName[7] = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

	return shortWeekName[NumberOfWeekOrder];
}

int main()
{
	cout << "Vacation Starts :\n";
	sDate Date = ReadFullDate();
	short vVacationDays = VacationDays();

	Date = VacationDate(Date, vVacationDays);

	cout << "\n\nReturn Date: " << ShortMonthName(DayOfWeekOrder(Date.Day, Date.Month, Date.Year)) <<" , "<< Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	_getch();
	return 0;
}

