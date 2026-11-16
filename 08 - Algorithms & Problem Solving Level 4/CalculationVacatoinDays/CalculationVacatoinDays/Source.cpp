#include<iostream>
#include<conio.h>
#include<string>
using  namespace std;

struct sDate
{
	short Day;
	short Month;
	short Year;
};

short ReadDay()
{
	short Day;
	cout << "Please enter the day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month;
	cout << "Please enter the Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year;
	cout << "Please enter the Year? ";
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

string DayShortName(short DayWeekOrder)
{
	string arrDay[7] = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

	return arrDay[DayWeekOrder];
}

short DaysOfWeekOrder(short Day, short Month, short Year)
{
	short a, y, m;

	a = (14 - Month) / 12;
	y = Year - a;
	m = Month + (12 * a) - 2;

	return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

bool Date1LessDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true :
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short MonthOfDay(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;

	short MonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? isLeapYear(Year) ? 29 : 28 : MonthDays[Month - 1];
}

bool isLastDayOfMonth(short Day, short Month, short Year)
{
	return (Day == MonthOfDay(Month, Year));
}

bool isLastMonthOfYear(short Month)
{
	return (Month == 12);
}

sDate IncreaseOneDay(sDate Date1, sDate Date2)
{
	if (isLastDayOfMonth(Date1.Day, Date1.Month, Date1.Year))
	{
		if (isLastMonthOfYear(Date1.Month))
		{
			Date1.Day = 1;
			Date1.Month = 1;
			Date1.Year++;
		}
		else
		{
			Date1.Day = 1;
			Date1.Month++;
		}
	}
	else
	{
		Date1.Day++;
	}
	return Date1;
}

bool isWeekEnd(sDate Date1)
{
	return (DaysOfWeekOrder(Date1.Day, Date1.Month, Date1.Year) == 6 || DaysOfWeekOrder(Date1.Day, Date1.Month, Date1.Year) == 5);
}

short CountOfDaysBetweenDates(sDate Date1, sDate Date2)
{
	short Days = 0;

	while (Date1LessDate2(Date1, Date2))
	{
		Date1 = IncreaseOneDay(Date1, Date2);

		if (!isWeekEnd(Date1))
			Days++;
	}

	return Days;
}

int main()
{
	cout << "Vacation Starts:\n";
	sDate Date1 = ReadFullDate();
	cout << "\n\nVacation Ends:\n";
	sDate Date2 = ReadFullDate();


	cout << "\n\nVaction From : " << DayShortName(DaysOfWeekOrder(Date1.Day, Date1.Month, Date1.Year)) << " , " << Date1.Day << "/" << Date1.Month << "/" << Date1.Year << endl;
	cout << "Vaction To   : " << DayShortName(DaysOfWeekOrder(Date2.Day, Date2.Month, Date2.Year)) << " , " << Date2.Day << "/" << Date2.Month << "/" << Date2.Year << endl;

	cout << "\n\nActucal vacation Days is: " << CountOfDaysBetweenDates(Date1, Date2) << "\n";

	_getch();
	return 0;
}

