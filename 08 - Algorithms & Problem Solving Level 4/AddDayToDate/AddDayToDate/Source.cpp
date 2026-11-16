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
	short arrMonthDays[12] = { 31, 30, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrMonthDays[Month - 1];
}

short NumberOfDaysInAYears(short Day, short Month, short Year)
{
	short TotalDays = 0;

	for (short i = 1; i <= Month - 1; i++)
	{
		TotalDays += NumberOfDaysInMonth(i, Year);
	}
	TotalDays += Day;
	return TotalDays;
}

short ReadDay()
{
	short Day = 0;
	cout << "Please enter a day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month = 0;
	cout << "Please enter a day? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year = 0;
	cout << "Please enter a day? ";
	cin >> Year;

	return Year;
}

short ReadAddDays()
{
	short AddDay = 0;
	cout << "How many to add? ";
	cin >> AddDay;

	return AddDay;
}

sDate ReadFullDate()
{
	sDate Date;
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();
	return Date;
}

sDate ConvertDayToDate(sDate Date, short Days)
{
	int TotalDays = Days + NumberOfDaysInAYears(Date.Day, Date.Month, Date.Year);
	short MonthDays = 0;
	Date.Month = 1;

	while (true)
	{
		MonthDays = NumberOfDaysInMonth(Date.Month, Date.Year);
		Date.Month++;

		if (TotalDays > MonthDays)
		{
			TotalDays -= MonthDays;
			if (Date.Month == 12)
			{
				Date.Month = 1;
				Date.Year++;
			}
		}
		else
		{
			Date.Day = TotalDays;
			break;
		}
	}
	return Date;
}

int main()
{
	sDate Date = ReadFullDate();
	short Days = ReadAddDays();

	Date = ConvertDayToDate(Date, Days);

	cout << "\nDate after adding [" << Days << "] days is: ";
	cout << Date.Day << "/" << Date.Month <<"/"<< Date.Year << endl;
	_getch();
	return 0;
}