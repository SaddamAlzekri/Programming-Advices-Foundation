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

struct Period
{
	sDate StartDate;
	sDate EndDate;
};

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
	short Year;
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
	Period Period;
	
	cout << "Enter Start Date: \n\n";
	Period.StartDate = ReadFullDate();

	cout << "\n\nEnter End Date: \n\n";
	Period.EndDate = ReadFullDate();

	return Period;
}

bool isDate1BeforeDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true :
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) :
		false);
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberofMonthDays(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;

	short arrMonthDay[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 12) ? isLeapYear(Year) ? 29 : 28 : arrMonthDay[Month - 1];
}

bool isLastDayInMonth(short Day, short Month, short Year)
{
	return (Day == NumberofMonthDays(Month, Year));
}

bool isLastMonthInYear(short Month)
{
	return (Month == 12);
}

sDate IncreaseOneDay(sDate Date)
{
	if (isLastDayInMonth(Date.Day, Date.Month, Date.Year))
	{
		if (isLastMonthInYear(Date.Month))
		{
			Date.Day = 1;
			Date.Month = 1;
			Date.Year++;
		}
		else
		{
			Date.Day = 1;
			Date.Month += 1;
		}
	}
	else
	{
		Date.Day++;
	}
	return Date;
}

short NumberOfPeriodOverLap(sDate Date1, sDate Date2, bool includeEndDate = false)
{
	short Day = 0;

	while (isDate1BeforeDate2(Date1, Date2))
	{
		Date1 = IncreaseOneDay(Date1);

		Day++;
	}

	return (includeEndDate) ? ++Day : Day;
}

int main()
{
	cout << "Enter Period 1: \n";
	Period Period1 = ReadPeriod();

	cout << "\n\nPeriod Lenght is: " << NumberOfPeriodOverLap(Period1.StartDate, Period1.EndDate) << endl;

	cout << "Period Length (Include End Date) is: " << NumberOfPeriodOverLap(Period1.StartDate, Period1.EndDate, true) << endl;
	
	_getch();
	return 0;
}