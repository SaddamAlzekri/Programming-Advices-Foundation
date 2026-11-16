#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;
struct sDate
{
	short Day = 0;
	short Month = 0;
	short Year = 0;
};

struct Period
{
	sDate StartDate;
	sDate EndDate;
};

enum enCompareDate
{
	Before = -1, Equal = 0, After = 1
};

short ReadDay()
{
	short Day = 0;
	cout << "Please enter a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month = 0;
	cout << "Please enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year = 0;
	cout << "Please enter a Year? ";
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

Period ReadPeriod()
{
	Period period;
	cout << "Enter Start Date:\n\n";
	period.StartDate = ReadFullDate();
	cout << "\n\nEnter End Date:\n\n";
	period.EndDate = ReadFullDate();

	return period;
}

bool isDate1BeforeDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true :
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)): false);
}

bool isDate1EqualDate2(sDate Date1, sDate Date2)
{
	if (Date1.Year == Date2.Year && Date1.Month == Date2.Month && Date1.Day == Date2.Day)
		return true;
	return false;
}

bool isDate1AfterDate2(sDate Date1, sDate Date2)
{
	if (!isDate1BeforeDate2(Date1, Date2) && !isDate1EqualDate2(Date1, Date2))
		return true;
	return false;
}

enCompareDate isCompareDate(sDate Date1, sDate Date2)
{
	if (isDate1BeforeDate2(Date1, Date2))
		return enCompareDate::Before;
	if (isDate1EqualDate2(Date1, Date2))
		return enCompareDate::Equal;

	return enCompareDate::After;

}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfMonthDay(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;

	short MonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : MonthDays[Month - 1];
}

bool isNumberOfMonthDays(sDate Date)
{
	return (Date.Day == NumberOfMonthDay(Date.Month, Date.Year));
}

bool isLastMonthInYear(short Month)
{
	return (Month == 12);
}

sDate IncreaseOneDay(sDate Date)
{
	if (isNumberOfMonthDays(Date))
	{
		if (isLastMonthInYear(Date.Month))
		{
			Date.Day = 1;
			Date.Month = 1;
			Date.Year += 1;
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

short OverLapPeriodDays(Period Period, bool IncludeEndDay = false)
{
	short Day = 0;
	while (isDate1BeforeDate2(Period.StartDate, Period.EndDate))
	{
		Period.StartDate = IncreaseOneDay(Period.StartDate);
		Day++;
	}

	return (IncludeEndDay) ? ++Day : Day;
}

bool isOverLapPeriods(Period Period1, Period Period2)
{
	if (isCompareDate(Period2.EndDate, Period1.StartDate) == enCompareDate::Before
		||
		isCompareDate(Period2.StartDate, Period1.EndDate) == enCompareDate::After)
		return false;
	else
		return true;
}

bool isDateinPeriodOverLap(sDate Date, Period Period)
{
	return !(isCompareDate(Date, Period.StartDate) == enCompareDate::Before || isCompareDate(Date, Period.EndDate) == enCompareDate::After);
}

int CountOverLap(Period Period1, Period Period2)
{
	int Period1Length = OverLapPeriodDays(Period1, true);
	int Period2Length = OverLapPeriodDays(Period2, true);
	int OverLabDays = 0;

	if (!isOverLapPeriods(Period1, Period2))
		return 0;

	if (Period1Length < Period2Length)
	{
		while (isDate1BeforeDate2(Period1.StartDate, Period1.EndDate))
		{
			if (isDateinPeriodOverLap(Period1.StartDate, Period2))
				OverLabDays++;

			Period1.StartDate = IncreaseOneDay(Period1.StartDate);
		}
	}
	else if (Period1Length > Period2Length)
	{
		while (isDate1BeforeDate2(Period2.StartDate, Period2.EndDate))
		{
			if (isDateinPeriodOverLap(Period2.StartDate, Period1))
				OverLabDays++;

			Period2.StartDate = IncreaseOneDay(Period2.StartDate);
		}
	}
	return OverLabDays;
}

int main()
{
	cout << "Enter Period 1:\n";
	Period period1 = ReadPeriod();

	cout << "\n\nEnter Period 2:\n";
	Period period2 = ReadPeriod();
	cout <<"Overlap Days Count is: "<<CountOverLap(period1, period2);

	_getch();
	return 0;
}