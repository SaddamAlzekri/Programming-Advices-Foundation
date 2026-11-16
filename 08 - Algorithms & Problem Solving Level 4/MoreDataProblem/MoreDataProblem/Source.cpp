#include<iostream>
#include<conio.h>
#include<string>
#include<ctime>
using namespace std;

struct sDate
{
	short Day;
	short Month;
	short Year;
};

short DayOfWeekOrder(short Day, short Month, short Year)
{
	short a, y, m;

	a = (14 - Month) / 12;
	y = Year - a;
	m = Month + (12 * a) - 2;

	return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

string DayShortName(short DayWeekOrder)
{
	string arrShortName[] = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

	return arrShortName[DayWeekOrder];
}

sDate GetSystemDate()
{
	sDate Date;

	time_t t = time(0);
	tm* now = localtime(&t);

	Date.Day = now->tm_mday;
	Date.Month = now->tm_mon + 1;
	Date.Year = now->tm_year + 1900;

	return Date;
}

short isEndOfWeek(short WeekDayOrder)
{
	return (WeekDayOrder == 6);
}

short isWeekEnd(short WeekDayOrder)
{
	return (WeekDayOrder == 5 || WeekDayOrder == 6);
}

short isBusinessDay(short WeekDayOrder)
{
	return (!isWeekEnd(WeekDayOrder));
}

short DaysUnitTheEndOfWeek(short WeekDayOrder)
{
	return (6 - WeekDayOrder);
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfMonthDays(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;
	short arrNumberMonthDays[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrNumberMonthDays[Month - 1];
}

short DaysUntilAndOfWeek(sDate Date)
{
	short MonthDay = NumberOfMonthDays(Date.Month, Date.Year);
	return (MonthDay - Date.Day);
}

bool Date1LessDate2(sDate Date, sDate DateFromStartYear)
{
	return (DateFromStartYear.Year > Date.Year) ? true :
		((DateFromStartYear.Year == Date.Year) ? (DateFromStartYear.Month > Date.Month ? true :
		(DateFromStartYear.Month == Date.Month ? DateFromStartYear.Day > Date.Day : false)) : false);

}

bool isLastDayInMonth(sDate Date)
{
	return (Date.Day == NumberOfMonthDays(Date.Month, Date.Year));
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

short GetDaysbetweenDates(sDate Date1, sDate Date2, bool EndDay = false)
{
	short Days = 0;
	while (Date1LessDate2(Date1, Date2))
	{

		Days++;
		Date1 = IncreaseOneDay(Date1);
	}

	return EndDay ? ++Days : Days;
}

short DaysUntilAndOfYear(sDate Date)
{
	sDate EndOfMonthDate;

	EndOfMonthDate.Day = 31;
	EndOfMonthDate.Month = 12;
	EndOfMonthDate.Year = Date.Year;

	return GetDaysbetweenDates(Date, EndOfMonthDate, true);
}

int main()
{
	sDate Date = GetSystemDate();

	cout << "Today is " << DayShortName(DayOfWeekOrder(Date.Day, Date.Month, Date.Year))
		<< " , " << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	cout << "\n\nIs it End Of Week? ";
	if (isEndOfWeek(DayOfWeekOrder(Date.Day, Date.Month, Date.Year)))
		cout << "\nYes Saterday is end of week .\n";
	else
		cout << "\nNo Not end of week.\n";


	cout << "\n\nIs it Week End? ";
	if (isWeekEnd(DayOfWeekOrder(Date.Day, Date.Month, Date.Year)))
		cout << "\nYes it is a week end.\n";
	else
		cout << "\nNo Not is a week end.\n";

	cout << "\n\nIs it Business Day? ";
	if (isBusinessDay(DayOfWeekOrder(Date.Day, Date.Month, Date.Year)))
		cout << "\nYes it is a Busssiness day.\n";
	else
		cout << "\nNo it is Not a Busssiness day.\n";

	cout << "Days untill end of week : " << DaysUnitTheEndOfWeek(DayOfWeekOrder(Date.Day, Date.Month, Date.Year)) << " Day(s).\n";
	cout << "Days until and of Month : " << DaysUntilAndOfWeek(Date) << " Day(s).\n";
	cout << "Days until and of Year : " << DaysUntilAndOfYear(Date) << " Day(s).\n";

	_getch();
	return 0;
}
