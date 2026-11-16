#include<iostream>
#include<conio.h>
#include<string>
#include<ctime>
#include<string.h>
using namespace std;
struct sDate
{
	short Day;
	short Month;
	short Year;
};

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfMonthDays(short Month, short Year)
{
	short arrMonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrMonthDays[Month - 1];
}

short isDate1LessDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true :
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

short NumberDaysOfMonth(sDate Date)
{
	short arrNumberOfDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Date.Month == 2) ? isLeapYear(Date.Year) ? 29 : 28 : arrNumberOfDays[Date.Month - 1];
}

bool isLastDayInMonth(sDate Date)
{
	return (Date.Day == NumberDaysOfMonth(Date));
}

bool isLastMonthInYear(sDate Date)
{
	return (Date.Month == 12);
}

sDate IncreaseOneDay(sDate Date)
{
	if (isLastDayInMonth(Date))
	{
		if (isLastMonthInYear(Date))
		{
			Date.Month = 1;
			Date.Day = 1;
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

void SwapValue(sDate &Date1, sDate &Date2)
{
	sDate Currunt;
	
	Currunt.Day = Date1.Day;
	Currunt.Month = Date1.Month;
	Currunt.Year = Date1.Year;

	Date1.Day = Date2.Day;
	Date1.Month = Date2.Month;
	Date1.Year = Date2.Year;

	Date2.Day = Currunt.Day;
	Date2.Month = Currunt.Month;
	Date2.Year = Currunt.Year;
}

int GetDaysbetweenDates(sDate Date1, sDate Date2, bool EndDay = false)
{
	short Days = 0;
	short SwapFlagValue = 1;

	if (!(isDate1LessDate2(Date1, Date2)))
	{
		SwapValue(Date1, Date2);
		SwapFlagValue = -1;
	}
	
	while (isDate1LessDate2(Date1, Date2))
	{
		Days++;
		Date1 = IncreaseOneDay(Date1);
	}

	return EndDay ? ++Days * SwapFlagValue : Days * SwapFlagValue;
}

short ReadDay()
{
	short Day = 0;
	cout << "Please entr a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month = 0;
	cout << "Please entr a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year = 0;
	cout << "Please entr a Year? ";
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


int main()
{
	sDate Date1, Date2;
	short GetDaysbetweenDate = 0;

	Date1 = ReadFullDate();
	cout << "\n\n";
	Date2 = ReadFullDate();

		cout << "\n\nDifferent is: " << GetDaysbetweenDates(Date1, Date2) << endl;

		cout << "Diffrence (Including End Day) is: " << GetDaysbetweenDates(Date1, Date2, true) << " Day(s)";

	_getch();
	return 0;
}