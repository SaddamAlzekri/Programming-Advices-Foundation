#include<iostream>
#include<conio.h>
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

short NumberOfDaysInMonth(short Month, short Year)
{
	short arrMonthDay[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : arrMonthDay[Month - 1];
}

short DaysOfYear(sDate Date)
{
	short TotalDay = 0;
	for (short i = 1; i <= Date.Month - 1; i++)
	{
		TotalDay += NumberOfDaysInMonth(i, Date.Year);
	}
		
	TotalDay += Date.Day;

	return TotalDay;
}

short ReadDay()
{
	short Day = 0;
	cout << "please enter a day? ";
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

sDate inCreaseOndayToDate(sDate Date, short vDaysOfYear)
{
	short MonthDays = 0;
	Date.Month = 1;

	while (true)
	{
		MonthDays = NumberOfDaysInMonth(Date.Month, Date.Year);
		

		if (vDaysOfYear >  MonthDays)
		{
			vDaysOfYear -= MonthDays;
			Date.Month++;
			if (Date.Month > 12)
			{
				Date.Month = 1;
				Date.Year++;
			}
		}
		else
		{
			Date.Day = vDaysOfYear;
			break;
		}
	}
	return Date;
}

int main()
{
	sDate Date = ReadFullDate();

	short vDaysOfYear = DaysOfYear(Date);
	
	Date = inCreaseOndayToDate(Date, vDaysOfYear + 1);

	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
	
	_getch();
	return 0;
}